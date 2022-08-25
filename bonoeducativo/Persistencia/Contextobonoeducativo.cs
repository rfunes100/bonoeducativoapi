using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bonoeducativo.Modelo;
using Microsoft.EntityFrameworkCore;


namespace bonoeducativo.Persistencia
{
    public class Contextobonoeducativo : DbContext
    {
        public Contextobonoeducativo() { }

        public Contextobonoeducativo(DbContextOptions<Contextobonoeducativo> options) : base(options) { }

        public DbSet<associated> associated { get; set; }
        public DbSet<relative_associated> relative_associated { get; set; }







    }
}
