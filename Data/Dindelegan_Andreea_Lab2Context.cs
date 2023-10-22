using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dindelegan_Andreea_Lab2.Models;

namespace Dindelegan_Andreea_Lab2.Data
{
    public class Dindelegan_Andreea_Lab2Context : DbContext
    {
        public Dindelegan_Andreea_Lab2Context (DbContextOptions<Dindelegan_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dindelegan_Andreea_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dindelegan_Andreea_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
