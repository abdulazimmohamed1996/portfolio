using Core.Entites;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Presentation_Layer.Models;
using Presentation_Layer.ViewModels;
using System.Diagnostics;

namespace Presentation_Layer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortofolioItem> _portofolio;

        public HomeController(IUnitOfWork<Owner> owner , IUnitOfWork<PortofolioItem> portofolio)
        {
            _owner = owner;
            _portofolio = portofolio;
        }

        public IActionResult Index()
        {
            var homviewmodel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll().First(),
                PortofolioItems =_portofolio.Entity.GetAll().ToList()
            };
            return View(homviewmodel);
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}