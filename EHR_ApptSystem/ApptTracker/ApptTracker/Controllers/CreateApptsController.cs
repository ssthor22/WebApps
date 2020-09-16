using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApptTracker.Data;
using ApptTracker.Models;

namespace ApptTracker.Controllers
{
    public class CreateApptsController : Controller
    {
        private readonly ApptTrackerContext _context;

        public CreateApptsController(ApptTrackerContext context)
        {
            _context = context;
        }

        // GET: CreateAppts
        public async Task<IActionResult> Index()
        {
            return View(await _context.CreateAppt.ToListAsync());
        }

        // GET: CreateAppts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var createAppt = await _context.CreateAppt
                .FirstOrDefaultAsync(m => m.ID == id);
            if (createAppt == null)
            {
                return NotFound();
            }

            return View(createAppt);
        }

        // GET: CreateAppts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CreateAppts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,firstname,lastname,apptdate,appttime,apptlength,reason")] CreateAppt createAppt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(createAppt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(createAppt);
        }

        // GET: CreateAppts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var createAppt = await _context.CreateAppt.FindAsync(id);
            if (createAppt == null)
            {
                return NotFound();
            }
            return View(createAppt);
        }

        // POST: CreateAppts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,firstname,lastname,apptdate,appttime,apptlength,reason")] CreateAppt createAppt)
        {
            if (id != createAppt.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(createAppt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CreateApptExists(createAppt.ID))
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
            return View(createAppt);
        }

        // GET: CreateAppts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var createAppt = await _context.CreateAppt
                .FirstOrDefaultAsync(m => m.ID == id);
            if (createAppt == null)
            {
                return NotFound();
            }

            return View(createAppt);
        }

        // POST: CreateAppts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var createAppt = await _context.CreateAppt.FindAsync(id);
            _context.CreateAppt.Remove(createAppt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CreateApptExists(int id)
        {
            return _context.CreateAppt.Any(e => e.ID == id);
        }
    }
}
