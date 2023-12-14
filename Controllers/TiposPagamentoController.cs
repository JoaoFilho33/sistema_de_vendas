#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using trabalho_final.Models;

namespace pagamentoProduto.Controllers
{
    public class TiposPagamentoController : Controller
    {
        private readonly MyDbContext _context;

        public TiposPagamentoController(MyDbContext context)
        {
            _context = context;
        }

        // GET: TiposPagamento
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoPagamento.ToListAsync());
        }

        // GET: TiposPagamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPagamento = await _context.TipoPagamento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoPagamento == null)
            {
                return NotFound();
            }

            return View(tipoPagamento);
        }

        // GET: TiposPagamento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposPagamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeDoCobrado,InformacoesAdicionais")] TipoPagamento tipoPagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoPagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoPagamento);
        }

        // GET: TiposPagamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPagamento = await _context.TipoPagamento.FindAsync(id);
            if (tipoPagamento == null)
            {
                return NotFound();
            }
            return View(tipoPagamento);
        }

        // POST: TiposPagamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeDoCobrado,InformacoesAdicionais")] TipoPagamento tipoPagamento)
        {
            if (id != tipoPagamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoPagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoPagamentoExists(tipoPagamento.Id))
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
            return View(tipoPagamento);
        }

        // GET: TiposPagamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPagamento = await _context.TipoPagamento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoPagamento == null)
            {
                return NotFound();
            }

            return View(tipoPagamento);
        }

        // POST: TiposPagamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoPagamento = await _context.TipoPagamento.FindAsync(id);
            _context.TipoPagamento.Remove(tipoPagamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoPagamentoExists(int id)
        {
            return _context.TipoPagamento.Any(e => e.Id == id);
        }
    }
}
