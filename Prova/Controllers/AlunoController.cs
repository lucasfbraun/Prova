using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova.Models;
using System.Data.Entity;

namespace Prova.Controllers
{
    public class AlunoController : Controller
    {
        private ApplicationDbContext _context;

         public AlunoController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var alunos = _context.Alunos.ToList();
            return View(alunos);
        }

        public ActionResult Details(int Id)
        {
             var aluno = _context.Alunos.SingleOrDefault(c => c.Id == Id);


            if (aluno == null)
                return HttpNotFound();
            return View();
        }
	}
}