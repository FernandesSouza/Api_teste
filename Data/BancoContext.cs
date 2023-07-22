using Api_teste.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_teste.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) :base(options)
        {

            
            
        }

      public  DbSet<CarrosModel> Carros { get; set; }

    }
}
