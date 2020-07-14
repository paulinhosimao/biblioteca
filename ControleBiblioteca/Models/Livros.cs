using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleBiblioteca.Models
{
    public class Livros
    {
        [Display(Name = "Código de barra")]
        public int IdCodBarra { get; set; }

        [Display(Name = "Status do livro")]
        public string Status { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DtCadastro { get; set; }

        [Display(Name = "Nome do livro")]
        public string NomeLivro { get; set; }

        [Display(Name = "Data de publicação")]
        public DateTime DtPublicacao { get; set; }

        [Display(Name = "Quantidade de páginas")]
        public int QtdPaginas { get; set; }

        [Display(Name = "Nome do autor")]
        public string Autor { get; set; }

        [Display(Name = "Imagem")]
        public string ImgCapa { get; set; }

        [Display(Name = "Unidade")]
        public string Unidade { get; set; }
    }
}