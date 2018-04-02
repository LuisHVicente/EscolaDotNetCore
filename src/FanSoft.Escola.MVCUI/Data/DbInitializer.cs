using System;
using System.Collections.Generic;
using System.Linq;

namespace FanSoft.Escola.MVCUI.Data
{
    public class DbInitializer
    {
        public static void Init(EscolaDataContext ctx) {

            ctx.Database.EnsureCreated();
            if (!ctx.Escolas.Any())
            {
                ctx.Escolas.AddRange(
                        new List<Models.Escola>{
                            new Models.Escola{ Nome = "FanSoft Sistema de Ensino",DataFundacao=new DateTime(1979,09,12),Endereco="Av. Paulista, 1500"},
                            new Models.Escola{ Nome = "Escola Nacional Diretiva",DataFundacao=new DateTime(1999,08,21),Endereco="Rua das Flores, 2199"},
                            new Models.Escola{ Nome = "Ensino Modular",DataFundacao=new DateTime(2007,01,1),Endereco="Av. Carioca, 231"},
                        }
                    );

                ctx.SaveChanges();
            }
        }
    }
}
