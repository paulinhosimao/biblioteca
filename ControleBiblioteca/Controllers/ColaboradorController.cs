using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControleBiblioteca.Models;

namespace ControleBiblioteca.Controllers
{
    public class ColaboradorController : Controller
    {
        public ActionResult Index()
        {
            return View(ColaboradorREP.Colabs);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Detalhes(int id)
        {
            var colabor = ColaboradorREP.Colabs.FirstOrDefault(n => n.IdColaborador == id);
            return View(colabor);
        }


        public ActionResult Alterar(int id)
        {
            var colabor = ColaboradorREP.Colabs.FirstOrDefault(n => n.IdColaborador == id);
            return View(colabor);
        }




    }
}