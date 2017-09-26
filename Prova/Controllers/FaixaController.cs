using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova.Models;
using System.Data.Entity;

namespace Prova.Controllers
{
    public class FaixaController : Controller
    {
         private ApplicationDbContext _context;

         public FaixaController()
        {
            _context = new ApplicationDbContext();
        }
         protected override void Dispose(bool disposing)
         {
             _context.Dispose();
         }
         public ActionResult Index()
         {
             var faixas = _context.Faixas.ToList();
             return View(faixas);
         }

        // GET: /Faixa/
        public ActionResult Details(int Id)
        {
               var faixa = _context.Faixas.SingleOrDefault(c => c.Id == Id);


            if (faixa == null)
                return HttpNotFound();
            return View();
    
        }
	}
}