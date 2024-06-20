using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestKT.Models;

namespace TestKT.Controllers
{
    public class LinhController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LinhController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Linh
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Linh.Include(l => l.People);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Linh/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Linh == null)
            {
                return NotFound();
            }

            var linh = await _context.Linh
                .Include(l => l.People)
                .FirstOrDefaultAsync(m => m.IDten == id);
            if (linh == null)
            {
                return NotFound();
            }

            return View(linh);
        }

        // GET: Linh/Create
        public IActionResult Create()
        {
            ViewData["Ma"] = new SelectList(_context.People, "Ma", "Ma");
            return View();
        }

        // POST: Linh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDten,Ten,Tinhcach,Ma")] Linh linh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(linh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Ma"] = new SelectList(_context.People, "Ma", "Ma", linh.Ma);
            return View(linh);
        }

        // GET: Linh/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Linh == null)
            {
                return NotFound();
            }

            var linh = await _context.Linh.FindAsync(id);
            if (linh == null)
            {
                return NotFound();
            }
            ViewData["Ma"] = new SelectList(_context.People, "Ma", "Ma", linh.Ma);
            return View(linh);
        }

        // POST: Linh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IDten,Ten,Tinhcach,Ma")] Linh linh)
        {
            if (id != linh.IDten)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(linh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LinhExists(linh.IDten))
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
            ViewData["Ma"] = new SelectList(_context.People, "Ma", "Ma", linh.Ma);
            return View(linh);
        }

        // GET: Linh/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Linh == null)
            {
                return NotFound();
            }

            var linh = await _context.Linh
                .Include(l => l.People)
                .FirstOrDefaultAsync(m => m.IDten == id);
            if (linh == null)
            {
                return NotFound();
            }

            return View(linh);
        }

        // POST: Linh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Linh == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Linh'  is null.");
            }
            var linh = await _context.Linh.FindAsync(id);
            if (linh != null)
            {
                _context.Linh.Remove(linh);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LinhExists(string id)
        {
          return (_context.Linh?.Any(e => e.IDten == id)).GetValueOrDefault();
        }
    }
}
