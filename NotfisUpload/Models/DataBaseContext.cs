using Microsoft.EntityFrameworkCore;
using NotfisUpload.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotfisUpload.Models
{
    public class DataBaseContext : DbContext
    {
        internal object Intercambio;

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {

        }
        public DbSet<Arquivo> Arquivos { get; set; }
        public DbSet<Intercambio> Intercambios { get; set; }


    }
}
