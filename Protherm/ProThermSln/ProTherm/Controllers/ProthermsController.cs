using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProTherm;
using ProTherm.Models.ViewModels;

namespace ProTherm.Models
{
    public class ProthermsController : Controller
    {
        private readonly ProthermContext _context;

        public ProthermsController(ProthermContext context) /*, IProthermRepository repo)*/
        {
            _context = context;
            //repository = repo;
        }

        //private IProthermRepository repository;
        //public int PageSize = 4;

        //public IActionResult Search(int ProthermPage = 1)
        //    => View(new ProthermListViewModel
        //    {
        //        Protherms = repository.Protherm
        //            .OrderBy(m => m.EntryId)
        //            .Skip((ProthermPage - 1) * PageSize)
        //            .Take(PageSize),
        //        PagingInfo = new PagingInfo
        //        {
        //            CurrentPage = mutantPage,
        //            ItemsPerPage = PageSize,
        //            TotalItems = repository.Protherm.Count()
        //        }
        //    });


        // GET: Protherms
        //public async Task<IActionResult> Index(string searchString, int ProteinMinLen, int ProteinMaxLen)
        //{
        //    ViewData["CurrentFilter"] = searchString;

        //    var proteins = from p in _context.Protherm select p;

        //    if (!String.IsNullOrEmpty(searchString)) // if searchString is not empty
        //    {
        //        proteins = proteins.Where(p =>
        //                                    p.ProteinName.Contains(searchString));

        //    }

        //    proteins = (from p in _context.Protherm where (p.Length >= ProteinMinLen) && (p.Length <= ProteinMaxLen) select p);

        //    //return View(await _context.Protherm.ToListAsync());
        //    return View(await proteins.AsNoTracking().ToListAsync());
        //}

        public async Task<IActionResult> Index(ProthermSearchModel searchModel)
        {
            ViewData["searchString"] = searchModel.ProteinName;
            var search = new ProthermSearchLogic();
            var model = search.GetProtherm(searchModel);

            return View(await model.ToListAsync());
        }

        // GET: Protherms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var protherm = await _context.Protherm
                .FirstOrDefaultAsync(m => m.EntryId == id);
            if (protherm == null)
            {
                return NotFound();
            }

            return View(protherm);
        }

        // GET: Protherms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Protherms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EntryId,ProteinName,Source,Length,MolecularWt,PirId,SwissProtId,EcNum,PmdNum,WtPdb,MutPdb,WtPdbUrl,MutPdbUrl,Mutation,Chain,DGH2o,DdGH2o,DG,DdG,TM,DTM")] Protherm protherm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(protherm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(protherm);
        }

        // GET: Protherms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var protherm = await _context.Protherm.FindAsync(id);
            if (protherm == null)
            {
                return NotFound();
            }
            return View(protherm);
        }

        // POST: Protherms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EntryId,ProteinName,Source,Length,MolecularWt,PirId,SwissProtId,EcNum,PmdNum,WtPdb,MutPdb,WtPdbUrl,MutPdbUrl,Mutation,Chain,DGH2o,DdGH2o,DG,DdG,TM,DTM")] Protherm protherm)
        {
            if (id != protherm.EntryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(protherm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProthermExists(protherm.EntryId))
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
            return View(protherm);
        }

        // GET: Protherms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var protherm = await _context.Protherm
                .FirstOrDefaultAsync(m => m.EntryId == id);
            if (protherm == null)
            {
                return NotFound();
            }

            return View(protherm);
        }

        // POST: Protherms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var protherm = await _context.Protherm.FindAsync(id);
            _context.Protherm.Remove(protherm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProthermExists(int id)
        {
            return _context.Protherm.Any(e => e.EntryId == id);
        }
    }
}
