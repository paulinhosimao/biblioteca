using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControleBiblioteca.Models;

namespace ControleBiblioteca.Controllers
{
    public class LivrosController : Controller
    {
        // GET: Livros
        public ActionResult Index()
        {
            return View(LivrosREP.Livro);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Detalhes(int id)
        {
            var livroo = LivrosREP.Livro.FirstOrDefault(n => n.IdCodBarra == id);
            return View(livroo);
        }


        public ActionResult Alterar(int id)
        {
            var livroo = LivrosREP.Livro.FirstOrDefault(n => n.IdCodBarra == id);
            return View(livroo);
        }




    }
}