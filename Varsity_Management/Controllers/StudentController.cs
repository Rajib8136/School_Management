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
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var stu = _context.Students.Include(c => c.Asigns).ThenInclude(c => c.class_Management).ToList();
            return View(stu);
        }
         public IActionResult Create()
        {
            ViewBag.Class = new SelectList(_context.Class_Managements, "Id", "Class");
            return View();
          
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                 _context.Students.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Class = new SelectList(_context.Class_Managements, "Id", "Class");
            if (id == null)
            {
                return NotFound();
            }
            var stud = await _context.Students.FindAsync(id);
            if(stud == null)
            {
                return NotFound();
            }

            return View(stud);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, Student student)
        {
            if(id != student.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var sta = await _context.Students.FindAsync(id);

                sta.First_Name = student.First_Name;
                sta.Last_name = student.Last_name;
                sta.Full_Name = student.Full_Name;
                sta.Father_Name = student.Father_Name;
                sta.Mother_Name = student.Mother_Name;
                sta.Mobile_Number = student.Mobile_Number;
                sta.Address = student.Address;
                sta.Thana = student.Thana;
                sta.District = student.District;
                sta.Date_Of_Birth = student.Date_Of_Birth;
                sta.Id_card = student.Id_card;
                sta.Religions = student.Religions;
                sta.Nationlity = student.Nationlity;
                sta.Gender = student.Gender;
                sta.Identification = student.Identification;
                sta.Description = student.Description;
                 _context.Update(sta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                
            }
            return View(student);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var delts = await _context.Students.FirstOrDefaultAsync(c => c.Id == id);

            if(delts== null)
            {
                return NotFound();
            }
            return View(delts);

        }


        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            var dele = await _context.Students.FindAsync(id);
            _context.Students.Remove(dele);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        } 

        public IActionResult GatAsign()
        {
            //var model = new StudentViewModel();
            //var Classes = await _context.Class_Managements.ToListAsync();
            //var ClassName = new List<ClassViewModel>();
            //foreach(var item in Classes)
            //{
            //    ClassName.Add(new ClassViewModel { Id = item.Id, Class = item.Class, Section = item.Section });
            //}
            //model.classViewModels = ClassName;
            //return View(model);
          
           

            return View();
        }

        public async Task<IActionResult> GetInfo()
        {
            var data = await _context.Class_Managements.ToListAsync();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> GatAsign(Class_management cla)
        {
            
            var clasdata = _context.Add(cla);
            await _context.SaveChangesAsync();
           
            return RedirectToAction(nameof(GetInfo));
           


        }

    }
}
