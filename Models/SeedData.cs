using System;
using System.Linq;
using Megha_Stick.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Megha_Stick.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StickContext(
                serviceProvider.GetRequiredService<DbContextOptions<StickContext>>()))
            {
                // Look for any Stick
                if (context.Stick.Any())
                {
                    return;   // DB has been seeded
                }

                context.Stick.AddRange(
                    new Stick
                    {
                        Brand = "Brand A",
                        ManufactureDate = DateTime.Parse("2022-01-15"),
                        Material = "Wood",
                        Length = 30.5,
                        Price = 19.99M,
                        GripType = "Rubber",
                        Rating = CustomRatingScale.Two

                    },
                    new Stick
                    {
                        Brand = "Brand B",
                        ManufactureDate = DateTime.Parse("2022-02-20"),
                        Material = "Fiberglass",
                        Length = 28.0,
                        Price = 24.99M,
                        GripType = "Foam",
                        Rating = CustomRatingScale.Five
                    },
                    new Stick
                    {
                        Brand = "Brand C",
                        ManufactureDate = DateTime.Parse("2022-03-10"),
                        Material = "Aluminum",
                        Length = 32.0,
                        Price = 29.99M,
                        GripType = "Plastic",
                        Rating = CustomRatingScale.Three
                    },
                    new Stick
                    {
                        Brand = "Brand D",
                        ManufactureDate = DateTime.Parse("2022-04-05"),
                        Material = "Carbon Fiber",
                        Length = 31.5,
                        Price = 39.99M,
                        GripType = "Foam",
                        Rating = CustomRatingScale.Four
                    },

                    new Stick
                    {
                        Brand = "Brand E",
                        ManufactureDate = DateTime.Parse("2022-05-20"),
                        Material = "Wood",
                        Length = 29.0,
                        Price = 17.99M,
                        GripType = "Rubber",
                        Rating = CustomRatingScale.One
                    },
                    new Stick
                    {
                        Brand = "Brand F",
                        ManufactureDate = DateTime.Parse("2022-06-12"),
                        Material = "Fiberglass",
                        Length = 27.5,
                        Price = 26.99M,
                        GripType = "Foam",
                        Rating = CustomRatingScale.Three
                    },
                    new Stick
                    {
                        Brand = "Brand G",
                        ManufactureDate = DateTime.Parse("2022-07-08"),
                        Material = "Aluminum",
                        Length = 30.5,
                        Price = 31.99M,
                        GripType = "Plastic",
                        Rating = CustomRatingScale.Five
                    },
                    new Stick
                    {
                        Brand = "Brand H",
                        ManufactureDate = DateTime.Parse("2022-08-15"),
                        Material = "Carbon Fiber",
                        Length = 32.5,
                        Price = 42.99M,
                        GripType = "Foam",
                        Rating = CustomRatingScale.Two
                    },
                    new Stick
                        {
                        Brand = "Brand I",
                        ManufactureDate = DateTime.Parse("2022-09-20"),
                        Material = "Wood",
                        Length = 31.0,
                        Price = 25.99M,
                        GripType = "Rubber",
                        Rating = CustomRatingScale.Four
                        },
                    new Stick
                    {
                        Brand = "Brand J",
                        ManufactureDate = DateTime.Parse("2022-10-10"),
                        Material = "Fiberglass",
                        Length = 30.0,
                        Price = 38.99M,
                        GripType = "Silicone",
                        Rating = CustomRatingScale.Three
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
