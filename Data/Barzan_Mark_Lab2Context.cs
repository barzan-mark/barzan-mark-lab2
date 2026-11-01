using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Barzan_Mark_Lab2.Models;

namespace Barzan_Mark_Lab2.Data
{
    public class Barzan_Mark_Lab2Context : DbContext
    {
        public Barzan_Mark_Lab2Context (DbContextOptions<Barzan_Mark_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Barzan_Mark_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Barzan_Mark_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Barzan_Mark_Lab2.Models.Authors> Authors { get; set; } = default!;
    }
}
