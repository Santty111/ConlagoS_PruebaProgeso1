using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConlagoS_PruebaProgeso1.Models;

namespace ConlagoS_PruebaProgeso1.Data
{
    public class ConlagoS_PruebaProgeso1Context : DbContext
    {
        public ConlagoS_PruebaProgeso1Context (DbContextOptions<ConlagoS_PruebaProgeso1Context> options)
            : base(options)
        {
        }

        public DbSet<ConlagoS_PruebaProgeso1.Models.Cliente> Cliente { get; set; } = default!;
    }
}
