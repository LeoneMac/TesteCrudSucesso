using CrudSucesso.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CrudSucesso.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(
                serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (!context.Pacotes.Any())
                {
                    context.Pacotes.Add(new Pacote { DescPkg = "Pacote Sócio", Price = 220 });
                    context.Pacotes.Add(new Pacote { DescPkg = "Pacote Sócio Premium", Price = 300 });
                    context.Pacotes.Add(new Pacote { DescPkg = "Pacote de não associado", Price = 400 });

                }
                if (!context.Atividades.Any())
                {
                    context.Atividades.Add(new Atividade { DescAtv = "Atividade 1", Vacancies = 10, Price = 15 });
                    context.Atividades.Add(new Atividade { DescAtv = "Atividade 2", Vacancies = 15, Price = 25 });
                    context.Atividades.Add(new Atividade { DescAtv = "Atividade 3", Vacancies = 20, Price = 30 });
                }

                context.SaveChanges();
            }
        }
    }
}
