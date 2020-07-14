using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleBiblioteca.Models
{
    public class LivrosREP
    {
        private static List<Livros> livros;

        public static List<Livros> Livro
        {
            get
            {
                if (livros == null)
                    CriarLivros();

                return livros;
            }
        }

        private static void CriarLivros()
        {
            livros = new List<Livros>();
            

            livros.Add(new Livros
            {
                IdCodBarra = 01010,
                Status = "indisponível",
                NomeLivro = "O monge e o executivo",
                Autor = "James C. Hunter",
                DtPublicacao = DateTime.Today,
                DtCadastro = DateTime.Today,
                QtdPaginas = 120,
                ImgCapa = "C:/Projects/Brasil/ControleBiblioteca/ControleBiblioteca/Images/monge_.jpg",
                Unidade = "Sorocaba"

            });

            livros.Add(new Livros
            {
                IdCodBarra = 02020,
                Status = "disponível",
                NomeLivro = "A culpa é das estrelas",
                Autor = "John Green",
                DtPublicacao = DateTime.Today,
                DtCadastro = DateTime.Today,
                QtdPaginas = 180,
                ImgCapa = "C:/Projects/Brasil/ControleBiblioteca/ControleBiblioteca/Images/estrelas.jpg",
                Unidade = "Campinas"

            });

            livros.Add(new Livros
            {
                IdCodBarra = 030303,
                Status = "indisponível",
                NomeLivro = "Espada de Vidro",
                Autor = "Victoria Aveyard",
                DtPublicacao = DateTime.Today,
                DtCadastro = DateTime.Today,
                QtdPaginas = 220,
                ImgCapa = "C:/Projects/Brasil/ControleBiblioteca/ControleBiblioteca/Images/espada.jpg",
                Unidade = "Santos"

            });

            livros.Add(new Livros
            {
                IdCodBarra = 040404,
                Status = "disponível",
                NomeLivro = "O pequeno príncipe",
                Autor = "Antoine de Saint-Exupéry",
                DtPublicacao = DateTime.Today,
                DtCadastro = DateTime.Today,
                QtdPaginas = 240,
                ImgCapa = "C:/Projects/Brasil/ControleBiblioteca/ControleBiblioteca/Images/principe.jpg",
                Unidade = "São Paulo"

            });
        }
    }
}