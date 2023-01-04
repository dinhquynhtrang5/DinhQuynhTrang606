using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DinhQuynhTrang606.Models;

namespace DinhQuynhTrang606.Data
{
    public class DinhQuynhTrang606Context : DbContext
    {
        public DinhQuynhTrang606Context (DbContextOptions<DinhQuynhTrang606Context> options)
            : base(options)
        {
        }

        public DbSet<DinhQuynhTrang606.Models.CompanyDQT606> CompanyDQT606 { get; set; } = default!;
    }
}
