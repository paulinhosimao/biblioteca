using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControleBiblioteca.Models;

namespace ControleBiblioteca.Controllers
{
    public class UnidadeController : Controller
    {
        // GET: Livros
        public ActionResult Index()
        {
            return View(UnidadeREP.Uni);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Detalhes(int id)
        {
            var uni = UnidadeREP.Uni.FirstOrDefault(n => n.IdUnidade == id);
            return View(uni);
        }


        public ActionResult Alterar(int id)
        {
            var uni = UnidadeREP.Uni.FirstOrDefault(n => n.IdUnidade == id);
            return View(uni);
        }




    }
}