using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProTherm.Models;
using ProTherm.Models.ViewModels;

namespace ProTherm.Controllers
{
    public class HomeController : Controller
    {
        private IProThermRepository repository;
        public int PageSize = 4;

        public HomeController(IProThermRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index(int mutantPage = 1)
            => View(new MutantsListViewModel
            {
                Mutants = repository.Mutants
                    .OrderBy(m => m.mutantID)
                    .Skip((mutantPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = mutantPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Mutants.Count()
                }
            });
    }
}
