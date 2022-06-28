using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Varsity_Management.Data;
using Varsity_Management.Models;

namespace Varsity_Management.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TeacherController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var tec = _context.Teachers.ToList();

            return View(tec);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Teachers.Add(teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var tech = await _context.Teachers.FindAsync(id);
            if(tech == null)
            {
                return NotFound();
            }
            return View(tech);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, Teacher teacher)
        {
            if(id != teacher.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var techs = await _context.Teachers.FindAsync(id);
                techs.Name = teacher.Name;
                techs.Education_Result = teacher.Education_Result;
                techs.Grade = teacher.Grade;
                techs.Subject = teacher.Subject;

                _context.Update(techs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var del = await _context.Teachers.FirstOrDefaultAsync(c => c.Id == id);
            if(del == null)
            {
                return NotFound();
            }
            return View(del);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var delle = await _context.Teachers.FindAsync(id);
           
            _context.Teachers.Remove(delle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
