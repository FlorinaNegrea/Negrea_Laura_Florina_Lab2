using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Negrea_Laura_Florina_Lab2.Models;

namespace Negrea_Laura_Florina_Lab2.Data
{
    public class Negrea_Laura_Florina_Lab2Context : DbContext
    {
        public Negrea_Laura_Florina_Lab2Context (DbContextOptions<Negrea_Laura_Florina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Negrea_Laura_Florina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Negrea_Laura_Florina_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Negrea_Laura_Florina_Lab2.Models.Authors>? Authors { get; set; }

        public DbSet<Negrea_Laura_Florina_Lab2.Models.Category>? Category { get; set; }
    }
}
