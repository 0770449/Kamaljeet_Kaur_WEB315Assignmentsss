using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KamalSelectedBag.Models;

    public class KamalSelectedBagContext : DbContext
    {
        public KamalSelectedBagContext (DbContextOptions<KamalSelectedBagContext> options)
            : base(options)
        {
        }

        public DbSet<KamalSelectedBag.Models.Bag> Bag { get; set; }
    }
