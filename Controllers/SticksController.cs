using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Megha_Stick.Data;
using Megha_Stick.Models;

namespace Megha_Stick.Controllers
{
    public class SticksController : Controller
    {
        private readonly StickContext _context;

        public SticksController(StickContext context)
        {
            _context = context;
        }

        // GET: Sticks
        public async Task<IActionResult> Index(string searchString, string selectedGripType)
        {
            // Use LINQ to get list of GripTypes.

            IQueryable<string> gripTypesQuery = from s in _context.Stick
                                                orderby s.GripType
                                                select s.GripType;

            var sticks = from s in _context.Stick
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                sticks = sticks.Where(s => s.Brand.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(selectedGripType))
            {
                sticks = sticks.Where(x => x.GripType == selectedGripType);
            }

            var selectedGripTypeVM = new StickGripViewModel
            {
                GripTypes = new SelectList(await gripTypesQuery.Distinct().ToListAsync()),
                Sticks = await sticks.ToListAsync(),
            };

            return View(selectedGripTypeVM);
        }

        // GET: Sticks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stick = await _context.Stick
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stick == null)
            {
                return NotFound();
            }

            return View(stick);
        }

        // GET: Sticks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sticks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,ManufactureDate,Material,Length,Price,GripType,Rating")] Stick stick)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stick);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stick);
        }

        // GET: Sticks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stick = await _context.Stick.FindAsync(id);
            if (stick == null)
            {
                return NotFound();
            }
            return View(stick);
        }

        // POST: Sticks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,ManufactureDate,Material,Length,Price,GripType,Rating")] Stick stick)
        {
            if (id != stick.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stick);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StickExists(stick.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(stick);
        }

        // GET: Sticks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stick = await _context.Stick
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stick == null)
            {
                return NotFound();
            }

            return View(stick);
        }

        // POST: Sticks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stick = await _context.Stick.FindAsync(id);
            _context.Stick.Remove(stick);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StickExists(int id)
        {
            return _context.Stick.Any(e => e.Id == id);
        }
    }
}
