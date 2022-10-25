using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Golea_Ana_Lab2.Models;

namespace Golea_Ana_Lab2.Data
{
    public class Golea_Ana_Lab2Context : DbContext
    {
        public Golea_Ana_Lab2Context (DbContextOptions<Golea_Ana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Golea_Ana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Golea_Ana_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Golea_Ana_Lab2.Models.Author> Author { get; set; }

        public DbSet<Golea_Ana_Lab2.Models.Category> Category { get; set; }
    }
}
