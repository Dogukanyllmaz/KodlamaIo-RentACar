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
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            AddUpdateDeleteOperations(carManager, colorManager, brandManager, userManager, customerManager, rentalManager);

        }

        private static void GetCarDetail(CarManager carManager)
        {
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-15} | {3,-15} | {4,-13} | {5,-13} | {6,-15} ", "CarId",
                    "CarName", "BrandName", "ColorName", "ModelYear", "DailyPrice", "Description"));
                foreach (var car in result.Data)
                {
                    Console.WriteLine(String.Format("{0,-12} | {1,-12} | {2,-13} | {3,-13} | {4,-13} | {5,-13} | {6,-15} ",
                        car.Id, car.Name, car.BrandName, car.ColorName, car.ModelYear, car.DailyPrice, car.Description));
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddUpdateDeleteOperations(CarManager carManager, ColorManager colorManager, BrandManager brandManager, UserManager userManager, CustomerManager customerManager, RentalManager rentalManager)
        {
            Console.WriteLine(" 1- Car - Add New\n 2- Car - Update\n 3- Car - Delete(its not working)\n 4- Brand - Add New\n 5- Color - Add New\n 6- User - Add New\n 7- Customer - Add New\n 8- Rent A Car\n 9- Update Rented Car\n 10- Delete Rented Car");
            Console.WriteLine("-----------------------------------------------------------------");
            var choice1 = Convert.ToInt32(Console.ReadLine());
            //string choiceString = "";
            switch (choice1)
            {
                case 1:     //AddNewCar-------------------ITS WORKING
                    AddCar();
                    break;
                case 2:     //UpdateCar-------------------ITS WORKING
                    GetCarDetail(carManager);
                    UpdateCar(carManager);
                    break;
                case 3:     //AddNewBrand-------------------ITS WORKING
                    AddBrand(brandManager);
                    break;
                case 4:     //AddNewColor-------------------ITS WORKING
                    AddColor(colorManager);
                    break;
                case 5:     //AddNewUser-------------------ITS WORKING
                    AddUser(userManager);
                    break;
                case 6:     //AddNewCustomer-------------------ITS WORKING
                    AddCustomer(customerManager);
                    break;
                case 7:     //RentACar-------------------ITS WORKING
                    RentaCar(rentalManager);
                    break;
                case 8:     //UpdateRentedCar-------------------ITS WORKING
                    ReturnCar(rentalManager);
                    break;
                case 9:     //DeleteRentedCar-------------------ITS WORKING
                    DeleteRental(rentalManager);
                    break;
                default:
                    break;
            }
        }


        //-------------------------- Add-Delete-Update----------------------------------
        private static void DeleteRental(RentalManager rentalManager)
        {
            Console.WriteLine("Write Rental ID For Delete");
            int deleteRent = Convert.ToInt32(Console.ReadLine());
            rentalManager.Delete(rentalManager.GetRentalById(deleteRent).Data);
        }

        private static void ReturnCar(RentalManager rentalManager)
        {
            Console.WriteLine("Returned Car ID : ");
            int updateRentID = Convert.ToInt32(Console.ReadLine());
            Rental returnedCar = new Rental {CarId = updateRentID, ReturnDate = DateTime.Now};
            rentalManager.Update(returnedCar);
        }

        private static void RentaCar(RentalManager rentalManager)
        {
            Rental rental = new Rental();
            Console.WriteLine("Car ID : ");
            rental.CarId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer ID : ");
            rental.CustomerId = Convert.ToInt32(Console.ReadLine());
            rental.RentDate = DateTime.Now;
            rental.ReturnDate = null;
            Console.WriteLine(rentalManager.Add(rental).Message);
        }

        private static void AddCustomer(CustomerManager customerManager)
        {
            Customer customer1 = new Customer();
            Console.WriteLine("User ID : ");
            customer1.UserId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Company Name : ");
            customer1.CompanyName = Console.ReadLine();
            customerManager.Add(customer1);
        }

        private static void AddUser(UserManager userManager)
        {
            User user1 = new User();
            Console.WriteLine("First Name : ");
            user1.FirstName = Console.ReadLine();
            Console.WriteLine("Last Name : ");
            user1.LastName = Console.ReadLine();
            Console.WriteLine("E-mail : ");
            user1.Email = Console.ReadLine();
            Console.WriteLine("Password : ");
            user1.Password = Console.ReadLine();
            userManager.Add(user1);
        }

        private static void AddColor(ColorManager colorManager)
        {
            Color color1 = new Color();
            Console.WriteLine("Color Name: ");
            color1.Name = Console.ReadLine();
            colorManager.Add(color1);
        }

        private static void AddBrand(BrandManager brandManager)
        {
            Brand brand1 = new Brand();
            Console.WriteLine("Brand Name: ");
            brand1.Name = Console.ReadLine();
            brandManager.Add(brand1);
        }

        //private static void DeleteCar(CarManager carManager)
        //{
        //    Console.WriteLine("--Delete--");
        //    Console.WriteLine("Car ID: ");
        //    int deleteCar = Convert.ToInt32(Console.ReadLine());
        //    carManager.Delete();
        //}

        private static void UpdateCar(CarManager carManager)
        {
            Console.WriteLine("--Add--");
            Console.WriteLine("Car Id: ");
            int updateCarId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Car Name: ");
            string updateCarName = Console.ReadLine();
            Console.WriteLine("Brand Id: ");
            int updateBrandId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Color Id: ");
            int updateColorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daily Price: ");
            decimal updateDailyPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Model Year: ");
            int updateModelYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Description: ");
            string updateDescription = Console.ReadLine();

            Car updateCar = new Car
            {
                Id = updateCarId, BrandId = updateBrandId, Name = updateCarName, ColorId = updateColorId,
                DailyPrice = updateDailyPrice, Description = updateDescription, ModelYear = updateModelYear
            };
            carManager.Update(updateCar);
        }

        private static void AddCar()
        {
            Car newcar = new Car();

            Console.WriteLine("Car Name: ");
            newcar.Name = Console.ReadLine();
            Console.WriteLine("BrandId: ");
            newcar.BrandId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ColorId :");
            newcar.ColorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daily Price: ");
            newcar.DailyPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Model Year: ");
            newcar.ModelYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Description: ");
            newcar.Description = Console.ReadLine();

            Console.WriteLine(newcar.Name + "added");
        }
    }
}
