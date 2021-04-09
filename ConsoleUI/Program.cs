using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            // RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental
            {
                CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = null
            });
            rentalManager.Add(new Rental
            {
                CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 03, 25)
            });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllCarDetailDtos().Data)
            {
                Console.WriteLine(car.Model + " - " + car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice + "TL");
            }
        }
    }
}
