![GitHub Repo stars](https://img.shields.io/github/stars/dogukanyllmaz/rentalproject?color=yellow)

<h1 align="center">Rent a Car Project : Araba Kiralama Sistemi</h1> 

<p align="center">
  <img src="https://i.ytimg.com/vi/xAImzF4M2MM/maxresdefault.jpg" width= "600" alt ="Rent aCar">
</p>

## 🎯 About
- **Entities, DataAccess, Business, ConsoleUI ve WebAPI katmanlarından oluşmaktadır. Hala geliştirme aşamasında.**
- **[Sql query](https://github.com/Dogukanyllmaz/RentalProject/blob/master/RentaCarSQLQuery.sql) <--- göz atmak isteyenler.**

## Installation
Aşağıdaki paketler NuGet aracığıyla **DataAccess** katmanına eklenmelidir. <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `Microsoft.EntityFrameworkCore (3.1.11)` <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `Microsoft.EntityFrameworkCore.SqlServer (3.1.11)` <br>

Aşağıdaki paket NuGet aracığıyla **Core** katmanına eklenmelidir. <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `Microsoft.EntityFrameworkCore.SqlServer (3.1.11)` <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `Castle.Core (4.4.1)` <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `FluentValidation (9.5.1)` <br>

Aşağıdaki paketler NuGet aracığıyla **Business** katmanına eklenmelidir. <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `Autofac (6.1.0)` <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `Autofac.Extensions.DependencyInjection (7.1.0)` <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `Autofac.Extras.DynamicProxy (6.0.0)` <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `FluentValidation (9.5.1)` <br>

## Layers
🗃 **``Entities Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Car.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Entities/Concrete/Car.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Brand.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Entities/Concrete/Brand.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Color.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Entities/Concrete/Color.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Customer.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Entities/Concrete/Customer.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Rental.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Entities/Concrete/Rental.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [User.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Entities/Concrete/User.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DTOs`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarDetailDto.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Entities/DTOs/CarDetailDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalDetailDto.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Entities/DTOs/RentalDetailDto.cs) <br><br>

🗃 **``Business Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarManager.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Concrete/CarManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BrandManager.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Concrete/BrandManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ColorManager.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Concrete/ColorManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CustomerManager.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Concrete/CustomerManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalManager.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Concrete/RentalManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserManager.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Concrete/UserManager.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICarService.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Abstract/ICarService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IBrandService.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Abstract/IBrandService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IColorService.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Abstract/IColorService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICustomerService.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Abstract/ICustomerService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IRentalService.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Abstract/IRentalService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUserService.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Abstract/IUserService.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Constants`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Messages.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/Constants/Messages.cs) <br><br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DependencyResolvers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [AutofacBusinessModule.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``ValidationRules`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``FluentValidation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [BrandValidator.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/ValidationRules/FluentValidation/BrandValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [CarValidator.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/ValidationRules/FluentValidation/CarValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ColorValidator.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/ValidationRules/FluentValidation/ColorValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [CustomerValidator.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/ValidationRules/FluentValidation/CustomerValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [RentalValidator.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/ValidationRules/FluentValidation/RentalValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [UserValidator.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Business/ValidationRules/FluentValidation/UserValidator.cs) <br>

🗃 **``Data Access Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [RentalProjectContext.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Concrete/EntityFramework/RentalProjectContext.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfCarDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfBrandDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfColorDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfCustomerDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfRentalDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Concrete/EntityFramework/EfRentalDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfUserDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICarDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Abstract/ICarDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IBrandDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Abstract/IBrandDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IColorDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Abstract/IColorDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICustomerDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Abstract/ICustomerDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IRentalDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Abstract/IRentalDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUserDal.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/DataAccess/Abstract/IUserDal.cs) <br>

🗃 **``Core Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Aspects`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Validation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [ValidationAspect.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``CrossCuttingCorners`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Validation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ValidationTool.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/CrossCuttingCorners/Validation/ValidationTool.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Entities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IDto.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Entities/IDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEntity.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Entities/IEntity.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DataAccess`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEntityRepository.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/DataAccess/IEntityRepository.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [EfEntityRepositoryBase.cs](https://github.com/Dogukanyllmaz/RentalProject/tree/master/Core/DataAccess/EntityFramework) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Utilities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Results`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IDataResult.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Utilities/Results/Abstract/IDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IResult.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Utilities/Results/Abstract/IResult.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [DataResult.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Utilities/Results/Concrete/DataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SuccessDataResult.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Utilities/Results/Concrete/SuccessDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ErrorDataResult.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Utilities/Results/Concrete/ErrorDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Result.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Utilities/Results/Concrete/Result.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SuccessResult.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Utilities/Results/Concrete/SuccessResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ErrorResult.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Utilities/Results/Concrete/ErrorResult.cs) <br><br>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Interceptors`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [AspectInterceptorSelector.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [MethodInterception.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Utilities/Interceptors/MethodInterception.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [MethodInterceptionBaseAttribute.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs) <br>

🗃 **``Presentation Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Program.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/ConsoleUI/Program.cs)<br><br>

🗃 **``WebAPI Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📃 [Program.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/WebAPI/Program.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📃 [Startup.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/WebAPI/Startup.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Controllers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BrandsController.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/WebAPI/Controllers/BrandsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarsController.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/WebAPI/Controllers/CarsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ColorsController.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/WebAPI/Controllers/ColorsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CustomersController.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/WebAPI/Controllers/CustomersController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalsController.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/WebAPI/Controllers/RentalsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UsersController.cs](https://github.com/Dogukanyllmaz/RentalProject/blob/master/WebAPI/Controllers/UsersController.cs) <br><br>

## 🗃 SQL Query
&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentACarSQLQuery.sql](https://github.com/Dogukanyllmaz/RentalProject/blob/master/RentaCarSQLQuery.sql)

## Tables in Database
<table>
  <tr>
    <td>Cars</td>
     <td>Brands</td>
     <td>Colors</td>
  </tr>
  <tr>
    <td>

Variable Name | Data Type
------------ | -------------
Id | int
Name | NVARCHAR(50)
BrandId | int
ColorId | int
DailyPrice | decimal
ModelYear | int
Description | nvarchar(50)
   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | int
rName | nvarchar(50)
   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | int
Name | nvarchar(50)
   
   </td>
  </tr>
 </table>
 
 <table>
  <tr>
    <td>Customers</td>
     <td>Rentals</td>
     <td>Users</td>
  </tr>
  <tr>
    <td>

Variable Name | Data Type
------------ | -------------
Id | int
UserId | int
CompanyName | nvarchar(50)
   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | int
CarId | int
CustomerId | int
RentDate | datetime
ReturnDate | datetime

   </td>
    <td>

Variable Name | Data Type
------------ | -------------
UserId | int
FirstName | nvarchar(50)
LastName | nvarchar(50)
Email | nvarchar(50)
Password | nvarchar(50)

   </td>
  </tr>
 </table>
