using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleBiblioteca.Models
{
    public class UnidadeREP
    {
        private static List<Unidade> uni;

        public static List<Unidade> Uni
        {
            get
            {
                if (uni == null)
                    CriarUnidade();

                return uni;
            }
        }

        private static void CriarUnidade()
        {
            uni = new List<Unidade>();
            

            uni.Add(new Unidade
            {
                IdUnidade = 98,
                Nome = "Sorocaba",
                
            });

            uni.Add(new Unidade
            {
                IdUnidade = 78,
                Nome = "Campinas",

            });

            uni.Add(new Unidade
            {
                IdUnidade = 58,
                Nome = "São Paulo",

            });

            uni.Add(new Unidade
            {
                IdUnidade = 48,
                Nome = "Santos",

            });
        }
    }
}