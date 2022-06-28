using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Varsity_Management.Data;
using Varsity_Management.Models;
using Varsity_Management.ViewModel;

namespace Varsity_Management.Controllers
{
    public class ExamController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ExamController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var exams = _context.Exams.Include(c => c.StudentResults).ThenInclude(c => c.Exam).ToList();

            return View(exams);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Exam exam)
        {
            if (ModelState.IsValid)
            {
                _context.Exams.Add(exam);
                await _context.SaveChangesAsync();
            }
            return View(exam);

        }

        public async Task<IActionResult> ClassInfo()
        {
            var output = new List<ExamViewModel>();
            var data = await _context.StudentResults.Include(x => x.classManagement).Include(x => x.Exam).ToListAsync();
            if (data.Count > 0)
                output = data.Select(x => new ExamViewModel { Exam_Name = x.Exam?.Exam_Name, Class = x.classManagement?.Class }).ToList();

            return View(output);

        }

        public IActionResult AssignExam()
        {
            var model = new ExamViewModel();


            ViewBag.ExamId = new SelectList(_context.Exams, "Id", "Exam_Name");
            ViewBag.Class = new SelectList(_context.Class_Managements, "Id", "Class");

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> AssignExam(ExamViewModel input)
        {
            var model = new StudentAssingExam() { classManagementId = input.ClassId, ExamId = input.ExamId };
            await _context.StudentResults.AddAsync(model);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var student = await _context.Students.Include(c => c.StudentResults).FirstOrDefaultAsync(c => c.Id == id);
            var model = new StudentViewModel();
            if (student != null)
            {
                model.Full_Name = student.Full_Name;
                model.Id = student.Id;
            }

            var Exams = _context.Exams.ToList();
            var ExamName = new List<ExamViewModel>();
            foreach (var item in Exams)
            {
                if (student != null)
                {

                    if (student.StudentResults.Any(c => c.ExamId == item.Id))
                    {
                        ExamName.Add(new ExamViewModel()
                        {
                            Id = item.Id,
                            Exam_Name = item.Exam_Name,
                            Subject = item.Subject,
                            Mark = item.Mark,
                            Grade = item.Grade,
                            Session = item.Session
                        });
                    }
                    else
                    {
                        ExamName.Add(new ExamViewModel()
                        {
                            Id = item.Id,
                            Exam_Name = item.Exam_Name,
                            Subject = item.Subject,
                            Mark = item.Mark,
                            Grade = item.Grade,
                            Session = item.Session
                        });

                    }

                }
            }

            model.ExamViewModels = ExamName;
            return View(model);

        }


        [HttpPost]

        public async Task<IActionResult> Edit(StudentViewModel student)
        {
            var Student = _context.Students.Include(c => c.StudentResults).FirstOrDefault(c => c.Id == student.Id);
            if (Student == null)
            {
                Student.Full_Name = student.Full_Name;
                _context.Update(Student);
                foreach (var item in student.ExamViewModels)
                {
                    if (item != null)
                    {
                        var ExamRes = Student.StudentResults.FirstOrDefault(c => c.ExamId == item.Id);
                        if (ExamRes == null)
                        {
                            var Examcs = new StudentAssingExam() { ExamId = item.Id, classManagementId = item.Id };
                            _context.Add(Examcs);
                        }
                    }

                    else
                    {
                        var Examcrd = _context.StudentResults.FirstOrDefault(c => c.ExamId == item.Id);
                        if (Examcrd != null)
                            _context.Update(Examcrd);
                    }
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AssignExam));
        }

    }
}






