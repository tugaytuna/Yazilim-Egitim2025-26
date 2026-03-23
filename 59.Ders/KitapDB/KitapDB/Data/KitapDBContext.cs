using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KitapDB.Models;

namespace KitapDB.Data
{
    public class KitapDBContext : DbContext
    {
        public KitapDBContext (DbContextOptions<KitapDBContext> options)
            : base(options)
        {
        }

        public DbSet<KitapDB.Models.Kitap> Kitap { get; set; } = default!;
    }
}
