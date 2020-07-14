using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleBiblioteca.Models
{
    public class Unidade
    {
        [Display(Name = "Código da unidade")]
        public int IdUnidade { get; set; }

        [Display(Name = "Nome da unidade")]
        public string Nome { get; set; }

   

        
    }
}