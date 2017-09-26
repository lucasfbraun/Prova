using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova.Models;
using System.Data.Entity;

namespace Prova.Controllers
{
    public class TipoAssociacaoController : Controller
    {
        private ApplicationDbContext _context;

         public TipoAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }
         protected override void Dispose(bool disposing)
         {
             _context.Dispose();
         }
  
      public ActionResult Index()
        {
            var tipos = _context.Tipos.ToList();
            return View(tipos);
        }
      public ActionResult Details(int Id)
      {
          var tipos = _context.Tipos.SingleOrDefault(c => c.Id == Id);


          if (tipos == null)
              return HttpNotFound();

          return View(tipos);

      }
	}
}