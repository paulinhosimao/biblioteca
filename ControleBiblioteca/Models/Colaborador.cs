using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleBiblioteca.Models
{
    public class Colaborador
    {
        [Display(Name = "Código do colaborador")]
        public int IdColaborador { get; set; }

        [Display(Name = "Nome do colaborador")]
        public string Nome { get; set; }

        [Display(Name = "Cpf")]
        public string Cpf { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Celular")]
        public string Celular { get; set; }

        
    }
}