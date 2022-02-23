using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
//using KamalSelectedBag.Data;

namespace KamalSelectedBag.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KamalSelectedBagContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<KamalSelectedBagContext>>()))
            {
                // Look for any cars.
                if (context.Bag.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bag.AddRange(
                    new Bag
                    {
                        Type = "BagPack",
                        Packingdate =  DateTime.Parse("2001-1-1"),
                        Color = "Blue",
                        Price = 1
                    },
                    new Bag
                    {
                        Type = "Purse",
                        Packingdate =  DateTime.Parse("2001-1-1"),
                        Color = "Blue",
                        Price = 7
                    },
                    new Bag
                    {
                         Type = "HandBag",
                        Packingdate =  DateTime.Parse("2001-1-1"),
                        Color = "Blue",
                        Price = 1
                    },
                    new Bag
                    {
                        Type = "Short",
                        Packingdate =  DateTime.Parse("2001-1-1"),
                        Color = "Blue",
                        Price = 8
                    }
                );
                context.SaveChanges();
            }
        }
    }
}