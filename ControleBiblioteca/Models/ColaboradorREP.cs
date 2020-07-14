using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleBiblioteca.Models
{
    public class ColaboradorREP
    {
        private static List<Colaborador> colaboradores;

        public static List<Colaborador> Colabs
        {
            get
            {
                if (colaboradores == null)

                    CriarColab();

                return colaboradores;
            }
        }

        private static void CriarColab()
        {
            colaboradores = new List<Colaborador>();


            colaboradores.Add(new Colaborador
            {
                IdColaborador = 01,
                Nome = "Pedro Sampaio",
                Cpf = "000.000.000-99",
                Email = "teste@teste.com.br",
                Celular = "(15) 98111-1212"
                

            });

            colaboradores.Add(new Colaborador
            {
                IdColaborador = 02,
                Nome = "Ana Proença",
                Cpf = "111.000.000-99",
                Email = "fit@teste.com.br",
                Celular = "(15) 97747-1212"


            });

            colaboradores.Add(new Colaborador
            {
                IdColaborador = 03,
                Nome = "Ligia Correa",
                Cpf = "777.999.000-99",
                Email = "ligia.fit@teste.com.br",
                Celular = "(15) 88232-1212"


            });

            colaboradores.Add(new Colaborador
            {
                IdColaborador = 04,
                Nome = "Leonardo Pereira",
                Cpf = "111.333.666-99",
                Email = "leonardo@teste.com.br",
                Celular = "(15) 98766-2321"


            });
        }
    }
}