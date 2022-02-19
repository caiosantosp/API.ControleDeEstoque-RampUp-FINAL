using Microsoft.EntityFrameworkCore;
using ApiDeProdutos.Data;

namespace ApiDeProdutos.Context
{
    public class ProdutoContext : DbContext
    {

        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        
    }
}
