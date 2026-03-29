using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppAdvance.Models;

namespace WebAppAdvance.Common
{
    public class CarsTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        private readonly ICollection<Car> cars = new List<Car>()
        {
           new Car { Id = 1, Brand = "BMW", Model = "X5", Year = 2022, Pasengers = 5, PricePerDay = 150 },
            new Car { Id = 2, Brand = "Audi", Model = "A6", Year = 2021, Pasengers = 5, PricePerDay = 130 },
            new Car { Id = 3, Brand = "Mercedes", Model = "C220", Year = 2020, Pasengers = 5, PricePerDay = 140 },
            new Car { Id = 4, Brand = "Toyota", Model = "Corolla", Year = 2019, Pasengers = 5, PricePerDay = 70 },
            new Car { Id = 5, Brand = "Volkswagen", Model = "Golf", Year = 2018, Pasengers = 5, PricePerDay = 65 },
            new Car { Id = 6, Brand = "Ford", Model = "Focus", Year = 2017, Pasengers = 5, PricePerDay = 60 },
            new Car { Id = 7, Brand = "Honda", Model = "Civic", Year = 2021, Pasengers = 5, PricePerDay = 85 },
            new Car { Id = 8, Brand = "Hyundai", Model = "Tucson", Year = 2022, Pasengers = 5, PricePerDay = 110 },
            new Car { Id = 9, Brand = "Kia", Model = "Sportage", Year = 2023, Pasengers = 5, PricePerDay = 115 },
            new Car { Id = 10, Brand = "Nissan", Model = "Qashqai", Year = 2020, Pasengers = 5, PricePerDay = 95 },

            new Car { Id = 11, Brand = "Peugeot", Model = "3008", Year = 2021, Pasengers = 5, PricePerDay = 100 },
            new Car { Id = 12, Brand = "Renault", Model = "Megane", Year = 2019, Pasengers = 5, PricePerDay = 75 },
            new Car { Id = 13, Brand = "Skoda", Model = "Octavia", Year = 2022, Pasengers = 5, PricePerDay = 90 },
            new Car { Id = 14, Brand = "Mazda", Model = "CX-5", Year = 2021, Pasengers = 5, PricePerDay = 120 },
            new Car { Id = 15, Brand = "Subaru", Model = "Forester", Year = 2020, Pasengers = 5, PricePerDay = 110 },
            new Car { Id = 16, Brand = "Chevrolet", Model = "Malibu", Year = 2018, Pasengers = 5, PricePerDay = 80 },
            new Car { Id = 17, Brand = "Dacia", Model = "Duster", Year = 2022, Pasengers = 5, PricePerDay = 70 },
            new Car { Id = 18, Brand = "Volvo", Model = "XC60", Year = 2023, Pasengers = 5, PricePerDay = 160 },
            new Car { Id = 19, Brand = "Tesla", Model = "Model 3", Year = 2023, Pasengers = 5, PricePerDay = 180 },
            new Car { Id = 20, Brand = "Opel", Model = "Insignia", Year = 2019, Pasengers = 5, PricePerDay = 85 }
        };
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(cars);
        }
    }
}
