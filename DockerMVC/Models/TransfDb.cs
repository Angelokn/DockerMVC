using DockerMVC.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DockerMVC.Models
{
    //public class TransfDb
    //{
    //    public void TransfDadosDb(IApplicationBuilder app)
    //    {
    //        TransfDadosDb(app.ApplicationServices.GetRequiredService<ApplicationDbContext>());
    //    }

    //    public void TransfDadosDb(ApplicationDbContext AppDb)
    //    {
    //        AppDb.Database.Migrate();

    //        if(!AppDb.Produtos.Any())
    //        {
    //            AppDb.Produtos.AddRange(
    //                new Produto { Id = 1, Nome = "Lápis", Categoria = "Material", Quantidade = 50, Preco = 2.0M },
    //                new Produto { Id = 2, Nome = "Caderno 55", Categoria = "Caderno", Quantidade = 30, Preco = 25.0M },
    //                new Produto { Id = 3, Nome = "Mochila verde", Categoria = "Mochila", Quantidade = 20, Preco = 150.0M },
    //                new Produto { Id = 4, Nome = "Borracha", Categoria = "Material", Quantidade = 50, Preco = 1.5M }
    //                );
    //            AppDb.SaveChanges();
    //        }
    //        else
    //        {
    //            System.Console.WriteLine("Dados já existem");
    //        }
    //    }
    //}
}
