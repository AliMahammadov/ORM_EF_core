using Microsoft.EntityFrameworkCore;
using ORM_EF_core.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_core.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=ALI\\SQLEXPRESS;database=AB101FirstStep;integrated security = true;trusted_connection=true;Encrypt=false");


        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set;}

        public DbSet<Size> Sizes { get; set; }

    }
}
