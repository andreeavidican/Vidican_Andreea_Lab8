using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vidican_Andreea_Lab8.Models;

namespace Vidican_Andreea_Lab8.Data
{
    public class Vidican_Andreea_Lab8Context : DbContext
    {
        public Vidican_Andreea_Lab8Context (DbContextOptions<Vidican_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Vidican_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Vidican_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Vidican_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
