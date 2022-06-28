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
    public class ClassController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ClassController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Cls_Mange = _context.Class_Managements.ToList();
            return View(Cls_Mange);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Create(Class_management management)
        {
            if (ModelState.IsValid)
            {
                _context.Add(management);
                await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
            }
            return View(management );
        }

        public async Task<IActionResult> Edit (int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var cls = await _context.Class_Managements.FindAsync(id);
            if (cls == null)
            {
                return NotFound();
            }
            return View(cls);
        }


        [HttpPost]

        public async Task<IActionResult> Edit(int id, Class_management clss)
        {
            if(id != clss.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var datas = await _context.Class_Managements.FindAsync(id);
                    datas.Class = clss.Class;
                   datas.Section = clss.Section;
                datas.Number_Student = clss.Number_Student;

                _context.Update(datas);
                await _context.SaveChangesAsync();
              return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var dels = await _context.Class_Managements.FirstOrDefaultAsync(c => c.Id == id);
            if(id == null)
            {
                return NotFound();
            }
            return View(dels);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        { 
           
                var dells = await _context.Class_Managements.FindAsync(id);
                _context.Class_Managements.Remove(dells);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            
        }
    }
}
