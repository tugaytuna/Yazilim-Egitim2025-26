using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDIslemleri.Models;

namespace CRUDIslemleri.Data
{
    public class CRUDIslemleriContext : DbContext
    {
        public CRUDIslemleriContext (DbContextOptions<CRUDIslemleriContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDIslemleri.Models.Ogrenci> Ogrenci { get; set; } = default!;
    }
}
