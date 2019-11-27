﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.EmployeeType.Any())
                {
                    return;   // DB has been seeded
                }

                context.Canteen.AddRange(
                new Canteen
                {
                    Name = "nabuy",
                    Email = "Canteen@hotmail.com",
                    Line = "tee29909",
                    Call = "0805694931",
                    Status = "Open"

                }
                );

                context.CompanyCar.AddRange(
                new CompanyCar
                {
                    NameCompanyCar = "transport",
                    Seat = "Canteen@hotmail.com",
                    Line = "tee29909",
                    Call = "0805694931",
                    Status = "Open",


                }
                );


                context.Part.AddRange(
                new Part
                {

                    Name = "บางแสน",
                    Price = "200",


                }
                );

                context.Part.AddRange(
                new Part
                {

                    Name = "พัทยา",
                    Price = "500",


                }
                );

                context.Part.AddRange(
                new Part
                {

                    Name = "บ่านบึง",
                    Price = "400",


                }
                );

                context.Part.AddRange(
                new Part
                {

                    Name = "พนัสนิคม",
                    Price = "100",


                }
                );






                context.Position.AddRange(
                new Position
                {
                    PositionName = "admin"
                }
                );

                context.Position.AddRange(
                new Position
                {
                    PositionName = "Manager"
                }
                );
                context.Position.AddRange(
                new Position
                {
                    PositionName = "Employee"
                }
                );
                context.Position.AddRange(
               new Position
               {
                   PositionName = "CEO"
               }
               );



                /* ---------------------------------*/



                context.EmployeeType.AddRange(
                    new EmployeeType
                    {
                        EmployeeTypeName = "Full Time"
                    }
                    );
                context.EmployeeType.AddRange(
                   new EmployeeType
                   {
                       EmployeeTypeName = "Part Time"
                   }
                   );

                /*---------------------------------*/

                context.Location.AddRange(
                new Location
                {
                    LocationName = "2t30",
                    Note = "note"
                }
                );

                /*---------------------------------*/

                context.Department.AddRange(
                new Department
                {
                    DepartmentName = "Information Technology",
                    Image = "null",
                    Status = "open"
                }
                );
                context.Department.AddRange(
                new Department
                {
                    DepartmentName = "Production Department",
                    Image = "null",
                    Status = "open"
                }
                );
                context.Department.AddRange(
                    new Department
                    {
                        DepartmentName = "Sales Department",
                        Image = "null",
                        Status = "open"
                    }
                    );
                context.Department.AddRange(
                    new Department
                    {
                        DepartmentName = "Accounting Department",
                        Image = "null",
                        Status = "open"
                    }
                    );
                context.Department.AddRange(
                    new Department
                    {
                        DepartmentName = "Human Resource",
                        Image = "null",
                        Status = "open"
                    }
                    );

                /*---------------------------------*/

                context.Company.AddRange(
                    new Company
                    {
                        CompanyName = "Tbkk",
                        Image = "null",
                        Status = "open"
                    }
                    );

                context.SaveChanges();
                /*---------------------------------*/


            }



            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Login.Any())
                {
                    return;   // DB has been seeded
                }


                /*---------------------------------*/

                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "admin",

                        LastName = "admin",

                        Gender = "male",

                        Birthday = DateTime.Parse("1989-2-12"),

                        Email = "admin@hotmail.com",

                        Call = "0805694932",

                        Line = "tee29909",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1989-2-12"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 1,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 1
                    }
                    );









                /*222222222222222222222222222222222222222222222222222222222*/





                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "Athena",

                        LastName = "Collins",

                        Gender = "male",

                        Email = "admin@hotmail.com",

                        Call = "0805694932",

                        Line = "tee29909",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1989-2-12"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 5,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 4
                    }
                    );
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "Arista",

                        LastName = "Carter",

                        Gender = "male",

                        Email = "admin@hotmail.com",

                        Call = "0805694932",

                        Line = "tee29909",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1989-2-12"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 5,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 4
                    }
                    );
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "Aria",

                        LastName = "Campbell",

                        Gender = "male",

                        Email = "admin@hotmail.com",

                        Call = "0805694932",

                        Line = "tee29909",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1989-2-12"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 5,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 4
                    }
                    );
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "Ammie",

                        LastName = "Bennett",

                        Gender = "male",

                        Email = "admin@hotmail.com",

                        Call = "0805694932",

                        Line = "tee29909",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1989-2-12"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 4,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 4
                    }
                    );
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "Alyssa",

                        LastName = "Beckham",

                        Gender = "male",

                        Email = "admin@hotmail.com",

                        Call = "0805694932",

                        Line = "tee29909",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1989-2-12"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 4,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 4
                    }
                    );
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "Angela",

                        LastName = "Baker",

                        Gender = "male",

                        Email = "admin@hotmail.com",

                        Call = "0805694932",

                        Line = "tee29909",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1989-2-12"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 3,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 2,

                        Employee_PositionID = 3
                    }
                    );
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "Abigail",

                        LastName = "Anderson",

                        Gender = "male",

                        Email = "admin@hotmail.com",

                        Call = "0805694932",

                        Line = "tee29909",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1989-2-12"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 3,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 2,

                        Employee_PositionID = 3
                    }
                    );
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "Amber",

                        LastName = "Alexander",

                        Gender = "male",

                        Email = "admin@hotmail.com",

                        Call = "0805694932",

                        Line = "tee29909",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1989-2-12"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 2,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 2
                    }
                    );


                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "Amelia",

                        LastName = "Adams",

                        Gender = "male",

                        Email = "admin@hotmail.com",

                        Call = "0805694932",

                        Line = "tee29909",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1989-2-12"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 2,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 2
                    }
                    );

                //11
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "brooke",

                        LastName = "edward",

                        Gender = "male",

                        Email = "brooke@hotmail.com",

                        Call = "0859872658",

                        Line = "brooke152",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1992-10-12"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 2,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 2
                    }
                   );
                //12
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "alice",

                        LastName = "anissa",

                        Gender = "female",

                        Email = "alice@hotmail.com",

                        Call = "0847563259",

                        Line = "aliceWTF",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1990-7-2"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 5,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 3
                    }
                   );
                //13
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "ava",

                        LastName = "holly",

                        Gender = "female",

                        Email = "ava@hotmail.com",

                        Call = "0698745284",

                        Line = "avaava",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1994-10-22"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 4,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 4
                    }
                   );
                //14
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "opal",

                        LastName = "sophie",

                        Gender = "female",

                        Email = "opal@hotmail.com",

                        Call = "0897854632",

                        Line = "opal6322",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1988-12-20"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 4,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 3
                    }
                   );
                //15
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "max",

                        LastName = "william",

                        Gender = "male",

                        Email = "maxMCU@hotmail.com",

                        Call = "0998871275",

                        Line = "mimimax",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1988-5-10"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 3,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 3
                    }
                   );
                //16
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "layla",

                        LastName = "melyssa",

                        Gender = "female",

                        Email = "laylala@hotmail.com",

                        Call = "0875942368",

                        Line = "laylala",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1989-8-28"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 2,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 2,

                        Employee_PositionID = 2
                    }
                   );
                //17
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "morgen",

                        LastName = "rohan",

                        Gender = "male",

                        Email = "morgenrohan@hotmail.com",

                        Call = "0985314752",

                        Line = "morgenrohan",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1995-11-28"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 3,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 2,

                        Employee_PositionID = 4
                    }
                   );
                //18
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "oscar",

                        LastName = "serafim",

                        Gender = "male",

                        Email = "oscarcar@hotmail.com",

                        Call = "0986523798",

                        Line = "oscarcar",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1985-9-9"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 1,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 2,

                        Employee_PositionID = 2
                    }
                   );
                //19
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "evan",

                        LastName = "jacob",

                        Gender = "male",

                        Email = "evanTH@hotmail.com",

                        Call = "0988896571",

                        Line = "evanTH",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1995-10-9"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 2,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 2,

                        Employee_PositionID = 3
                    }
                   );
                //20
                context.Employee.AddRange(
                    new Employee
                    {


                        FirstName = "harry",

                        LastName = "joshua",

                        Gender = "male",

                        Email = "harry@hotmail.com",

                        Call = "0988896571",

                        Line = "harry",

                        Image = "null",

                        Addr = "tbkk",

                        Date = DateTime.Parse("1988-5-19"),

                        Status = "working",

                        Employee_CompanyID = 1,

                        Employee_DepartmentNameID = 5,

                        Employee_LocationID = 1,

                        Employee_EmployeeTypeID = 1,

                        Employee_PositionID = 4
                    }
                   );

                /*222222222222222222222222222222222222222222222222222222222*/





                /*---------------------------------*/


                context.Login.AddRange(
                new Login
                {
                    Username = "admin",

                    Password = "admin",

                    Login_EmployeeID = 1
                }
                );

                /*+++++++++++++++++++++++++++++++++++++++++++*/
                context.Login.AddRange(
                new Login
                {
                    Username = "user1",

                    Password = "user1",

                    Login_EmployeeID = 2
                }
                );
                context.Login.AddRange(
                new Login
                {
                    Username = "user2",

                    Password = "user2",

                    Login_EmployeeID = 3
                }
                );
                context.Login.AddRange(
                new Login
                {
                    Username = "user3",

                    Password = "user3",

                    Login_EmployeeID = 4
                }
                );
                context.Login.AddRange(
                new Login
                {
                    Username = "user4",

                    Password = "user4",

                    Login_EmployeeID = 5
                }
                );
                context.Login.AddRange(
                new Login
                {
                    Username = "user5",

                    Password = "user5",

                    Login_EmployeeID = 6
                }
                );
                context.Login.AddRange(
                new Login
                {
                    Username = "user6",

                    Password = "user6",

                    Login_EmployeeID = 7
                }
                );
                context.Login.AddRange(
                new Login
                {
                    Username = "user7",

                    Password = "user7",

                    Login_EmployeeID = 8
                }
                );
                context.Login.AddRange(
                new Login
                {
                    Username = "user8",

                    Password = "user8",

                    Login_EmployeeID = 9
                }
                );
                context.Login.AddRange(
                new Login
                {
                    Username = "user9",

                    Password = "user9",

                    Login_EmployeeID = 10
                }
                );
                context.Login.AddRange(
               new Login
               {
                   Username = "employee11",

                   Password = "employee11",

                   Login_EmployeeID = 11
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "employee12",

                   Password = "employee12",

                   Login_EmployeeID = 12
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "employee13",

                   Password = "employee13",

                   Login_EmployeeID = 13
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "employee14",

                   Password = "employee14",

                   Login_EmployeeID = 14
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "employee15",

                   Password = "employee15",

                   Login_EmployeeID = 15
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "employee16",

                   Password = "employee16",

                   Login_EmployeeID = 16
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "employee17",

                   Password = "employee17",

                   Login_EmployeeID = 17
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "employee18",

                   Password = "employee18",

                   Login_EmployeeID = 18
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "employee19",

                   Password = "employee19",

                   Login_EmployeeID = 19
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "employee20",

                   Password = "employee20",

                   Login_EmployeeID = 20
               }
               );

                /*+++++++++++++++++++++++++++++++++++++++++++*/







                context.CarType.AddRange(
                new CarType
                {

                    NameCar = "Canteen@hotmail.com",
                    Seat = "tee29909",
                    CarType_CompanyCarID = 1


                }
                );
                context.CarType.AddRange(
                new CarType
                {

                    NameCar = "ว่าง",
                    Seat = "0",
                    CarType_CompanyCarID = 1


                }
                );

                context.CarType.AddRange(
                new CarType
                {

                    NameCar = "สองแถวสองประตู",
                    Seat = "tee29909",
                    CarType_CompanyCarID = 1


                }
                );


                context.CarType.AddRange(
                new CarType
                {

                    NameCar = "สองแถวสี่ประตู",
                    Seat = "tee29909",
                    CarType_CompanyCarID = 1


                }
                );
                context.Brand.AddRange(
            new Brand
            {

                BrandName = "ว่าง",
                Image = ""



            }
            );

                context.FoodSet.AddRange(
              new FoodSet
              {

                  FoodSetcoManul = "ว่าง",
                  NameSet = "ไม่เลือก",
                  Canteen_CanteenID = 1


              }
              );

                context.FoodSet.AddRange(
                new FoodSet
                {

                    FoodSetcoManul = "อาหาร",
                    NameSet = "A",
                    Canteen_CanteenID = 1


                }
                );

                context.FoodSet.AddRange(
                new FoodSet
                {

                    FoodSetcoManul = "อาหาร",
                    NameSet = "B",
                    Canteen_CanteenID = 1


                }
                );


                context.OT.AddRange(
                new OT
                {

                    TimeStart = DateTime.Parse("8:00 AM"),
                    TimeEnd = DateTime.Parse("15:00 PM"),
                    TypeOT = "Nomal",
                    TypStatus = "Open"


                }
                );

                context.OT.AddRange(
                new OT
                {

                    TimeStart = DateTime.Parse("8:00 AM"),
                    TimeEnd = DateTime.Parse("15:00 PM"),
                    TypeOT = "Special",
                    TypStatus = "Open"


                }
                );
                context.OT.AddRange(
                new OT
                {

                    TimeStart = DateTime.Parse("8:00 AM"),
                    TimeEnd = DateTime.Parse("15:00 PM"),
                    TypeOT = "Nomal",
                    TypStatus = "Cloes"


                }
                );
                context.OT.AddRange(
                new OT
                {

                    TimeStart = DateTime.Parse("8:00 AM"),
                    TimeEnd = DateTime.Parse("15:00 PM"),
                    TypeOT = "Special",
                    TypStatus = "Cloes"

                }
                );
                context.OT.AddRange(
                new OT
                {

                    TimeStart = DateTime.Parse("8:00 AM"),
                    TimeEnd = DateTime.Parse("15:00 PM"),
                    TypeOT = "Nomal",
                    TypStatus = "Cloes"
                }
                 );
                context.OT.AddRange(
                new OT
                {

                    TimeStart = DateTime.Parse("8:00 AM"),
                    TimeEnd = DateTime.Parse("15:00 PM"),
                    TypeOT = "Nomal",
                    TypStatus = "Cloes"
                }
                );
                context.OT.AddRange(
                new OT
                {
                    TimeStart = DateTime.Parse("8:00 AM"),
                    TimeEnd = DateTime.Parse("15:00 PM"),
                    TypeOT = "Nomal",
                    TypStatus = "Cloes"
                }
                 );
                /*context.DetailOT.AddRange(
               new DetailOT
               {

                   TimeStart = DateTime.Parse("16:00"),
                   TimeEnd = DateTime.Parse("18:00"),
                   Hour = "2",
                   Type = "One-way",
                   CarNumber = "1",
                   Status = "pending",
                   Part_PaetID = 1,
                   FoodSet_FoodSetID = 2,
                   CarType_CarTypeID = 2, 
                   OT_OTID = 1, 
                   Employee_EmpID = 2 
               }
                );*/

                context.SaveChanges();
            }

            using (var context = new tbkkDataContext(
               serviceProvider.GetRequiredService<
                   DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.GradeHistory.Any())
                {
                    return;   // DB has been seeded
                }

                context.GradeHistory.AddRange(
                new GradeHistory
                {
                    GrahAllPoint = 4,
                    Count = 1,
                    GrahRound1 = 4,
                    GrahRound2 = 4,
                    GrahRound3 = 4,
                    GrahYear = "2562",
                    GrahBonusUp = 10000,
                    GrahSalaryUp = 25000,
                    GradeHistory_EmployeeID = 1
                }
                );
                context.GradeHistory.AddRange(
               new GradeHistory
               {
                   GrahAllPoint = 3,
                   Count = 2,
                   GrahRound1 = 3,
                   GrahRound2 = 3,
                   GrahRound3 = 3,
                   GrahYear = "2562",
                   GrahBonusUp = 5000,
                   GrahSalaryUp = 2000,
                   GradeHistory_EmployeeID = 4
               }
               );
                context.GradeHistory.AddRange(
               new GradeHistory
               {
                   GrahAllPoint = 5,
                   Count = 2,
                   GrahRound1 = 4,
                   GrahRound2 = 4,
                   GrahRound3 = 4,
                   GrahYear = "2562",
                   GrahBonusUp = 10000,
                   GrahSalaryUp = 25000,
                   GradeHistory_EmployeeID = 3
               }
               );
                context.GradeHistory.AddRange(
               new GradeHistory
               {
                   GrahAllPoint = 4,
                   Count = 1,
                   GrahRound1 = 4,
                   GrahRound2 = 4,
                   GrahRound3 = 4,
                   GrahYear = "2562",
                   GrahBonusUp = 10000,
                   GrahSalaryUp = 25000,
                   GradeHistory_EmployeeID = 8
               }
               );
                context.GradeHistory.AddRange(
               new GradeHistory
               {
                   GrahAllPoint = 3,
                   Count = 1,
                   GrahRound1 = 3,
                   GrahRound2 = 3,
                   GrahRound3 = 3,
                   GrahYear = "2562",
                   GrahBonusUp = 10000,
                   GrahSalaryUp = 25000,
                   GradeHistory_EmployeeID = 12
               }
               );
                context.Evaluation.AddRange(
               new Evaluation
               {
                   EvaDetail = "NULL",
                   EvaSumPoint = 4,
                   EvaDate = DateTime.Parse("2562-2-12"),
                   EvaStatus = 2,
                   Evatype = "1",
                   Eva_EmployeeID = 1,
                   Eva_GradeHistoryID = 1
               }
               );
                context.Evaluation.AddRange(
               new Evaluation
               {
                   EvaDetail = "NULL",
                   EvaSumPoint = 4,
                   EvaDate = DateTime.Parse("2562-2-12"),
                   EvaStatus = 2,
                   Evatype = "1",
                   Eva_EmployeeID = 4,
                   Eva_GradeHistoryID = 2
               }
               );
                context.Evaluation.AddRange(
               new Evaluation
               {
                   EvaDetail = "NULL",
                   EvaSumPoint = 4,
                   EvaDate = DateTime.Parse("2562-2-12"),
                   EvaStatus = 2,
                   Evatype = "1",
                   Eva_EmployeeID = 3,
                   Eva_GradeHistoryID = 3
               }
               );
                context.Evaluation.AddRange(
               new Evaluation
               {
                   EvaDetail = "NULL",
                   EvaSumPoint = 4,
                   EvaDate = DateTime.Parse("2562-2-12"),
                   EvaStatus = 2,
                   Evatype = "1",
                   Eva_EmployeeID = 8,
                   Eva_GradeHistoryID = 4
               }
               );
                context.Evaluation.AddRange(
               new Evaluation
               {
                   EvaDetail = "NULL",
                   EvaSumPoint = 4,
                   EvaDate = DateTime.Parse("2562-2-12"),
                   EvaStatus = 2,
                   Evatype = "1",
                   Eva_EmployeeID = 12,
                   Eva_GradeHistoryID = 5
               }
               );

                context.SaveChanges();
            }
        }
    }
}