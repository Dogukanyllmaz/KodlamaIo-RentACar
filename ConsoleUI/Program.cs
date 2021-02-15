using Business.Concrete;
using Core.Utilities.Results.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManeger = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //GetAllDetail(carManager); // Çalışıyor
            //TestDelete(carManager);
            //TestAdd(carManager); //Çalışıyor
            //TestUpdate(carManager);

            //TestColorAdd(colorManager); // Çalışıyor
            //TesstColorDelete(colorManager); 
            //TestUpdateColor(colorManager); 
            //TestColorGetAll(colorManager); //Çalışıyor

            //TestRentalAdd(rentalManager); //Çalışıyor
            //TestRentalGetAll(rentalManager); //Çalışıyor
            //TestRentalDelete(rentalManager);
            //TestRentalUpdate(rentalManager);

            //TestCustomerAdd(customerManeger); //Çalışıyor
            //TestCustomerDelete(customerManeger);
            //TestCustomerGetAll(customerManeger); //Çalışıyor
            //TestCustomerUpdate(customerManeger); //Çalışıyor

            //TestUserAdd(userManager); // Çalışıyor
            //TestGetAllUsers(userManager); // Çalışıyor
            //TestUserDelete(userManager);
            //TestUserUpdate(userManager); //Çalışıyor

            
        }

        private static void TestRentalUpdate(RentalManager rentalManager)
        {
            var result = rentalManager.Update(new Rental
            {
                Id = 1,
                CarId = 2,
                CustomerId = 9,
                RentDate = new DateTime(2021, 2, 5),
                ReturnDate = new DateTime(2021, 3, 1)
            });
            Console.WriteLine(result.Message);
        }

        private static void TestRentalDelete(RentalManager rentalManager)
        {
            var result = rentalManager.Delete(new Rental
            {
                Id = 7
            });
            Console.WriteLine(result.Message);
        }
        
        private static void TestRentalGetAll(RentalManager rentalManager)
        {
            var result = rentalManager.GetAllRentals();
            foreach (var rental in rentalManager.GetAllRentals().Data)
            {
                Console.WriteLine(rental.CarId);
            }

            Console.WriteLine(result.Message);
        }

        private static void TestColorGetAll(ColorManager colorManager)
        {
            var result = colorManager.GetColors();
            foreach (var color in colorManager.GetColors().Data)
            {
                Console.WriteLine(color.Name);
            }

            Console.WriteLine(result.Message);
        }

        private static void TestUpdateColor(ColorManager colorManager)
        {
            var result = colorManager.Update(new Color
            {
                Id = 1006,
                Name = "Uzay Gri"
            });
            Console.WriteLine(result.Message);
        }

        private static void TestUserUpdate(UserManager userManager)
        {
            var result = userManager.Update(new User
            {
                UserId = 5,
                FirstName = "Can",
                LastName = "Saru",
                Email = "cs12@gmail.com",
                Password = "124578"
            });
            Console.WriteLine(result.Message);
        }

        private static void TestCustomerUpdate(CustomerManager customerManeger)
        {
            var result = customerManeger.Update(new Customer
            {
                Id = 9,
                UserId = 2,
                CompanyName = "Lord Palace Hotel"
            });
            Console.WriteLine(result.Message);
        }
        //Tamamdır
        private static void TestCustomerGetAll(CustomerManager customerManeger)
        {
            var result = customerManeger.GetAllCustomers();
            foreach (var customer in customerManeger.GetAllCustomers().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void TestCustomerDelete(CustomerManager customerManeger)
        {
            var result = customerManeger.Delete(new Customer
            {
                Id = 9
            });
            Console.WriteLine(result.Message);
        }

        private static void TesstColorDelete(ColorManager colorManager)
        {
            var result = colorManager.Delete(new Color
            {
                Id = 1010
            });
            Console.WriteLine(result.Message);
        }

        private static void TestUserDelete(UserManager userManager)
        {
            var result = userManager.Delete(new User
            {
                UserId = 4
            });
            Console.WriteLine(result.Message);
        }

        private static void TestGetAllUsers(UserManager userManager)
        {
            var result = userManager.GetAllUsers();
            foreach (var user in userManager.GetAllUsers().Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }

        private static void TestCustomerAdd(CustomerManager customerManeger)
        {
            var result = customerManeger.Add(new Customer
            {
                UserId = 2,
                CompanyName = "Commencis"
            });
            Console.WriteLine(result.Message);
        }

        private static void TestUserAdd(UserManager userManager)
        {
            var result = userManager.Add(new User
            {
                FirstName = "İldem",
                LastName = "Koceli",
                Email = "12345@hotmail.com",
                Password = "12345"
            });
            Console.WriteLine(result.Message);
        }

        private static IResult TestRentalAdd(RentalManager rentalManager)
        {
            var result = rentalManager.Add(new Rental
            {
                CarId = 3,
                CustomerId = 5,
                RentDate = new DateTime(2021, 2, 12),
                ReturnDate = new DateTime(2021, 2, 25)
            });
            Console.WriteLine(result.Message);
            return result;
        }

        private static void TestColorAdd(ColorManager colorManager)
        {
            var result = colorManager.Add(new Color
            {
                Name = "Mat Siyah"
            });
            Console.WriteLine(result.Message);
        }

        private static void TestUpdate(CarManager carManager)
        {
            var result = carManager.Update(new Car
            {
                Id = 4,
                BrandId = 6,
                ColorId = 1007,
                Description = "1.6 Benzin"
            });
            Console.WriteLine(result.Message);
        }

        private static void TestAdd(CarManager carManager)
        {
            var result = carManager.Add(new Car
            {
                Name = "Clio",
                BrandId = 6,
                ColorId = 1007,
                ModelYear = 2018,
                DailyPrice = 225,
                Description = "1.6 Dizel",
            });
            Console.WriteLine(result.Message);
            GetAllDetail(carManager);
        }

        private static void TestDelete(CarManager carManager)
        {
            var result = carManager.Delete(new Car
            {
                Id = 3
            });
            Console.WriteLine(result.Message);
        }

        private static void GetAllDetail(CarManager carManager)
        {

            Console.WriteLine("Car Id\tCar Name\t\tBrand Name\tColor Name\tDaily Price");

            var result = carManager.GetCarDetails();

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(
                    $"{car.Id}\t{car.Name}\t{car.BrandName}\t{car.ColorName}\t{car.DailyPrice}");
            }

            Console.WriteLine("\n");
            Console.WriteLine(result.Message);
        }
    }
}
