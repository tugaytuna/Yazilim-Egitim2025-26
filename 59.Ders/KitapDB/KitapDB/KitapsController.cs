using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KitapDB.Data;
using KitapDB.Models;

namespace KitapDB
{
    public class KitapsController : Controller
    {
        private readonly KitapDBContext _context;

        public KitapsController(KitapDBContext context)
        {
            _context = context;
        }

        // GET: Kitaps
        public async Task<IActionResult> Index()
        {
            ViewBag.Liste = _context.Kitap.ToList();
            return View(await _context.Kitap.ToListAsync());
        }

        // GET: Kitaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitap = await _context.Kitap
                .FirstOrDefaultAsync(k=> k.KitapId == id);
            if (kitap == null)
            {
                //return View("Index");
                return NotFound();
            }

            return View(kitap);
        }

        // GET: Kitaps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kitaps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Kitap kitap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kitap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kitap);
        }

        // GET: Kitaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitap = await _context.Kitap.FindAsync(id);
            if (kitap == null)
            {
                return NotFound();
            }
            return View(kitap);
        }

        // POST: Kitaps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KitapId,Isim,Yazar,Tur,YayınEvi,SayfaSayisi,Okundu")] Kitap kitap)
        {
            if (id != kitap.KitapId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kitap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KitapExists(kitap.KitapId))
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
            return View(kitap);
        }

        // GET: Kitaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitap = await _context.Kitap
                .FirstOrDefaultAsync(m => m.KitapId == id);
            if (kitap == null)
            {
                return NotFound();
            }

            return View(kitap);
        }

        // POST: Kitaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kitap = await _context.Kitap.FindAsync(id);
            if (kitap != null)
            {
                _context.Kitap.Remove(kitap);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KitapExists(int id)
        {
            return _context.Kitap.Any(e => e.KitapId == id);
        }
    }
}
