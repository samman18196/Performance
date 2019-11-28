using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tbkkData.Migrations
{
    public partial class Intitail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "Canteen",
                columns: table => new
                {
                    CanteenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Line = table.Column<string>(nullable: true),
                    Call = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canteen", x => x.CanteenID);
                });

            migrationBuilder.CreateTable(
                name: "CarType_Cock",
                columns: table => new
                {
                    CarType_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CerNumber = table.Column<int>(nullable: false),
                    NameCar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarType_Cock", x => x.CarType_CockID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Company_Cock",
                columns: table => new
                {
                    Company_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company_Cock", x => x.Company_CockID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCar",
                columns: table => new
                {
                    CompanyCarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameCompanyCar = table.Column<string>(nullable: true),
                    Seat = table.Column<string>(nullable: true),
                    Line = table.Column<string>(nullable: true),
                    Call = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCar", x => x.CompanyCarID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Department_Cock",
                columns: table => new
                {
                    Department_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department_Cock", x => x.Department_CockID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                columns: table => new
                {
                    EmployeeTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.EmployeeTypeID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType_Cock",
                columns: table => new
                {
                    EmployeeType_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType_Cock", x => x.EmployeeType_CockID);
                });

            migrationBuilder.CreateTable(
                name: "FoodSet_Cock",
                columns: table => new
                {
                    FoodSet_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Manu = table.Column<string>(nullable: true),
                    NameSet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodSet_Cock", x => x.FoodSet_CockID);
                });

            migrationBuilder.CreateTable(
                name: "GradeHistory",
                columns: table => new
                {
                    GradeHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GrahAllPoint = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    GrahRound1 = table.Column<int>(nullable: false),
                    GrahRound2 = table.Column<int>(nullable: false),
                    GrahRound3 = table.Column<int>(nullable: false),
                    GrahYear = table.Column<string>(nullable: true),
                    GrahBonusUp = table.Column<int>(nullable: false),
                    GrahSalaryUp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeHistory", x => x.GradeHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Network",
                columns: table => new
                {
                    NetworkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NetworkName = table.Column<string>(nullable: true),
                    IpAddr = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Network", x => x.NetworkID);
                });

            migrationBuilder.CreateTable(
                name: "OT",
                columns: table => new
                {
                    OTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    TypeOT = table.Column<string>(nullable: true),
                    TypStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OT", x => x.OTID);
                });

            migrationBuilder.CreateTable(
                name: "OT_Cock",
                columns: table => new
                {
                    OT_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    TypeOT = table.Column<string>(nullable: true),
                    TypStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OT_Cock", x => x.OT_CockID);
                });

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    PartID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.PartID);
                });

            migrationBuilder.CreateTable(
                name: "Part_Cock",
                columns: table => new
                {
                    Part_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part_Cock", x => x.Part_CockID);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PositionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "Position_Cock",
                columns: table => new
                {
                    Position_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PositionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position_Cock", x => x.Position_CockID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SupplierName = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier_Cock",
                columns: table => new
                {
                    Supplier_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SupplierName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier_Cock", x => x.Supplier_CockID);
                });

            migrationBuilder.CreateTable(
                name: "FoodSet",
                columns: table => new
                {
                    FoodSetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FoodSetcoManul = table.Column<string>(nullable: true),
                    NameSet = table.Column<string>(nullable: true),
                    Canteen_CanteenID = table.Column<int>(nullable: false),
                    CanteenID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodSet", x => x.FoodSetID);
                    table.ForeignKey(
                        name: "FK_FoodSet_Canteen_CanteenID1",
                        column: x => x.CanteenID1,
                        principalTable: "Canteen",
                        principalColumn: "CanteenID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    ModelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModelName = table.Column<string>(nullable: true),
                    Model_BrandID = table.Column<int>(nullable: false),
                    BrandID1 = table.Column<int>(nullable: true),
                    Model_CategoryID = table.Column<int>(nullable: false),
                    CategoryID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.ModelID);
                    table.ForeignKey(
                        name: "FK_Model_Brand_BrandID1",
                        column: x => x.BrandID1,
                        principalTable: "Brand",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Model_Category_CategoryID1",
                        column: x => x.CategoryID1,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarType",
                columns: table => new
                {
                    CarTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameCar = table.Column<string>(nullable: true),
                    Seat = table.Column<string>(nullable: true),
                    CarType_CompanyCarID = table.Column<int>(nullable: false),
                    CompanyCarID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarType", x => x.CarTypeID);
                    table.ForeignKey(
                        name: "FK_CarType_CompanyCar_CompanyCarID1",
                        column: x => x.CompanyCarID1,
                        principalTable: "CompanyCar",
                        principalColumn: "CompanyCarID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    EvaluationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EvaDetail = table.Column<string>(nullable: true),
                    EvaSumPoint = table.Column<int>(nullable: false),
                    EvaDate = table.Column<DateTime>(nullable: false),
                    EvaStatus = table.Column<int>(nullable: false),
                    Evatype = table.Column<string>(nullable: true),
                    Eva_GradeHistoryID = table.Column<int>(nullable: false),
                    GradeHistoryID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.EvaluationID);
                    table.ForeignKey(
                        name: "FK_Evaluation_GradeHistory_GradeHistoryID1",
                        column: x => x.GradeHistoryID1,
                        principalTable: "GradeHistory",
                        principalColumn: "GradeHistoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Point",
                columns: table => new
                {
                    PointID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamePoint = table.Column<string>(nullable: true),
                    Point_PartID = table.Column<int>(nullable: false),
                    PartID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Point", x => x.PointID);
                    table.ForeignKey(
                        name: "FK_Point_Part_PartID1",
                        column: x => x.PartID1,
                        principalTable: "Part",
                        principalColumn: "PartID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Cock",
                columns: table => new
                {
                    Employee_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Employee_Cock_CompanyID = table.Column<int>(nullable: false),
                    CompanyIDCompany_CockID = table.Column<int>(nullable: true),
                    Employee_Cock_DepartmentNameID = table.Column<int>(nullable: false),
                    DepartmentIDDepartment_CockID = table.Column<int>(nullable: true),
                    Employee_Cock_LocationID = table.Column<int>(nullable: false),
                    LocationID1 = table.Column<int>(nullable: true),
                    Employee_Cock_EmployeeTypeID = table.Column<int>(nullable: false),
                    EmployeeTypeIDEmployeeType_CockID = table.Column<int>(nullable: true),
                    Employee_Cock_PositionID = table.Column<int>(nullable: false),
                    PositionIDPosition_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Cock", x => x.Employee_CockID);
                    table.ForeignKey(
                        name: "FK_Employee_Cock_Company_Cock_CompanyIDCompany_CockID",
                        column: x => x.CompanyIDCompany_CockID,
                        principalTable: "Company_Cock",
                        principalColumn: "Company_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Cock_Department_Cock_DepartmentIDDepartment_CockID",
                        column: x => x.DepartmentIDDepartment_CockID,
                        principalTable: "Department_Cock",
                        principalColumn: "Department_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Cock_EmployeeType_Cock_EmployeeTypeIDEmployeeType_CockID",
                        column: x => x.EmployeeTypeIDEmployeeType_CockID,
                        principalTable: "EmployeeType_Cock",
                        principalColumn: "EmployeeType_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Cock_Location_LocationID1",
                        column: x => x.LocationID1,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Cock_Position_Cock_PositionIDPosition_CockID",
                        column: x => x.PositionIDPosition_CockID,
                        principalTable: "Position_Cock",
                        principalColumn: "Position_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "License",
                columns: table => new
                {
                    LicenseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LicenseName = table.Column<string>(nullable: true),
                    SoftewareName = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    PONumber = table.Column<string>(nullable: true),
                    Attachfiles = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    License_ModelID = table.Column<int>(nullable: false),
                    ModelID1 = table.Column<int>(nullable: true),
                    License_SupplierID = table.Column<int>(nullable: false),
                    SupplierID1 = table.Column<int>(nullable: true),
                    License_DepartmentID = table.Column<int>(nullable: false),
                    DepartmentID1 = table.Column<int>(nullable: true),
                    License_CompanyID = table.Column<int>(nullable: false),
                    CompanyID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_License", x => x.LicenseID);
                    table.ForeignKey(
                        name: "FK_License_Company_CompanyID1",
                        column: x => x.CompanyID1,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_License_Department_DepartmentID1",
                        column: x => x.DepartmentID1,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_License_Model_ModelID1",
                        column: x => x.ModelID1,
                        principalTable: "Model",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_License_Supplier_SupplierID1",
                        column: x => x.SupplierID1,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Line = table.Column<string>(nullable: true),
                    Call = table.Column<string>(nullable: true),
                    Addr = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Employee_CompanyID = table.Column<int>(nullable: false),
                    CompanyID1 = table.Column<int>(nullable: true),
                    Employee_DepartmentNameID = table.Column<int>(nullable: false),
                    DepartmentID1 = table.Column<int>(nullable: true),
                    Employee_LocationID = table.Column<int>(nullable: false),
                    LocationID1 = table.Column<int>(nullable: true),
                    Employee_EmployeeTypeID = table.Column<int>(nullable: false),
                    EmployeeTypeID1 = table.Column<int>(nullable: true),
                    Employee_PositionID = table.Column<int>(nullable: false),
                    PositionID1 = table.Column<int>(nullable: true),
                    Employee_EvaluationID = table.Column<int>(nullable: false),
                    EvaluationID1 = table.Column<int>(nullable: true),
                    Employee_GradeHistoryID = table.Column<int>(nullable: false),
                    GradeHistoryID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_Company_CompanyID1",
                        column: x => x.CompanyID1,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentID1",
                        column: x => x.DepartmentID1,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeType_EmployeeTypeID1",
                        column: x => x.EmployeeTypeID1,
                        principalTable: "EmployeeType",
                        principalColumn: "EmployeeTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Evaluation_EvaluationID1",
                        column: x => x.EvaluationID1,
                        principalTable: "Evaluation",
                        principalColumn: "EvaluationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_GradeHistory_GradeHistoryID1",
                        column: x => x.GradeHistoryID1,
                        principalTable: "GradeHistory",
                        principalColumn: "GradeHistoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Location_LocationID1",
                        column: x => x.LocationID1,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Position_PositionID1",
                        column: x => x.PositionID1,
                        principalTable: "Position",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asset_Cock",
                columns: table => new
                {
                    Asset_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetName = table.Column<string>(nullable: true),
                    SerailNumber = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Department_Cock = table.Column<int>(nullable: false),
                    DepartmentIDDepartment_CockID = table.Column<int>(nullable: true),
                    Company_Cock = table.Column<int>(nullable: false),
                    CompanyIDCompany_CockID = table.Column<int>(nullable: true),
                    Supplier_Cock = table.Column<int>(nullable: false),
                    SupplierIDSupplier_CockID = table.Column<int>(nullable: true),
                    Employee_Cock = table.Column<int>(nullable: false),
                    EmployeeIDEmployee_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset_Cock", x => x.Asset_CockID);
                    table.ForeignKey(
                        name: "FK_Asset_Cock_Company_Cock_CompanyIDCompany_CockID",
                        column: x => x.CompanyIDCompany_CockID,
                        principalTable: "Company_Cock",
                        principalColumn: "Company_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Cock_Department_Cock_DepartmentIDDepartment_CockID",
                        column: x => x.DepartmentIDDepartment_CockID,
                        principalTable: "Department_Cock",
                        principalColumn: "Department_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Cock_Employee_Cock_EmployeeIDEmployee_CockID",
                        column: x => x.EmployeeIDEmployee_CockID,
                        principalTable: "Employee_Cock",
                        principalColumn: "Employee_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Cock_Supplier_Cock_SupplierIDSupplier_CockID",
                        column: x => x.SupplierIDSupplier_CockID,
                        principalTable: "Supplier_Cock",
                        principalColumn: "Supplier_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailOT_Cock",
                columns: table => new
                {
                    DetailOT_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hour = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    CarNumber = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Part_Cock_PaetID = table.Column<int>(nullable: false),
                    PartIDPart_CockID = table.Column<int>(nullable: true),
                    FoodSet_Cock_FoodSetID = table.Column<int>(nullable: false),
                    FoodSetIDFoodSet_CockID = table.Column<int>(nullable: true),
                    CarType_Cock_CarTypeID = table.Column<int>(nullable: false),
                    CarTypeIDCarType_CockID = table.Column<int>(nullable: true),
                    OT_Cock_OTID = table.Column<int>(nullable: false),
                    OTIDOT_CockID = table.Column<int>(nullable: true),
                    Employee_Cock_EmpID = table.Column<int>(nullable: false),
                    EmployeeIDEmployee_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailOT_Cock", x => x.DetailOT_CockID);
                    table.ForeignKey(
                        name: "FK_DetailOT_Cock_CarType_Cock_CarTypeIDCarType_CockID",
                        column: x => x.CarTypeIDCarType_CockID,
                        principalTable: "CarType_Cock",
                        principalColumn: "CarType_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_Cock_Employee_Cock_EmployeeIDEmployee_CockID",
                        column: x => x.EmployeeIDEmployee_CockID,
                        principalTable: "Employee_Cock",
                        principalColumn: "Employee_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_Cock_FoodSet_Cock_FoodSetIDFoodSet_CockID",
                        column: x => x.FoodSetIDFoodSet_CockID,
                        principalTable: "FoodSet_Cock",
                        principalColumn: "FoodSet_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_Cock_OT_Cock_OTIDOT_CockID",
                        column: x => x.OTIDOT_CockID,
                        principalTable: "OT_Cock",
                        principalColumn: "OT_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_Cock_Part_Cock_PartIDPart_CockID",
                        column: x => x.PartIDPart_CockID,
                        principalTable: "Part_Cock",
                        principalColumn: "Part_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UpdateLicense",
                columns: table => new
                {
                    UpdateLicenseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    LicenseName = table.Column<string>(nullable: true),
                    SoftwareName = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    PONumber = table.Column<string>(nullable: true),
                    Attachfiles = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    UpdateLicense_ModelID = table.Column<int>(nullable: false),
                    ModelID1 = table.Column<int>(nullable: true),
                    UpdateLicense_SupplierID = table.Column<int>(nullable: false),
                    SupplierID1 = table.Column<int>(nullable: true),
                    UpdateLicense_DepartmentID = table.Column<int>(nullable: false),
                    DepartmentID1 = table.Column<int>(nullable: true),
                    UpdateLicense_CompanyID = table.Column<int>(nullable: false),
                    CompanyID1 = table.Column<int>(nullable: true),
                    UpdateLicense_LicenseID = table.Column<int>(nullable: false),
                    LicenseID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateLicense", x => x.UpdateLicenseID);
                    table.ForeignKey(
                        name: "FK_UpdateLicense_Company_CompanyID1",
                        column: x => x.CompanyID1,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateLicense_Department_DepartmentID1",
                        column: x => x.DepartmentID1,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateLicense_License_LicenseID1",
                        column: x => x.LicenseID1,
                        principalTable: "License",
                        principalColumn: "LicenseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateLicense_Model_ModelID1",
                        column: x => x.ModelID1,
                        principalTable: "Model",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateLicense_Supplier_SupplierID1",
                        column: x => x.SupplierID1,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    AssetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetName = table.Column<string>(nullable: true),
                    SerailNumber = table.Column<string>(nullable: true),
                    MACAddr = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    PONumber = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Warranty = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Asset_LocationID = table.Column<int>(nullable: false),
                    LocationID1 = table.Column<int>(nullable: true),
                    Asset_CompanyID = table.Column<int>(nullable: false),
                    CompanyID1 = table.Column<int>(nullable: true),
                    Asset_DepartmentID = table.Column<int>(nullable: false),
                    DepartmentID1 = table.Column<int>(nullable: true),
                    Asset_SupplierID = table.Column<int>(nullable: false),
                    SupplierID1 = table.Column<int>(nullable: true),
                    Asset_EmployeeID = table.Column<int>(nullable: false),
                    EmployeeID1 = table.Column<int>(nullable: true),
                    Asset_ModelID = table.Column<int>(nullable: false),
                    ModelID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.AssetID);
                    table.ForeignKey(
                        name: "FK_Asset_Company_CompanyID1",
                        column: x => x.CompanyID1,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Department_DepartmentID1",
                        column: x => x.DepartmentID1,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Employee_EmployeeID1",
                        column: x => x.EmployeeID1,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Location_LocationID1",
                        column: x => x.LocationID1,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Model_ModelID1",
                        column: x => x.ModelID1,
                        principalTable: "Model",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Supplier_SupplierID1",
                        column: x => x.SupplierID1,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailOT",
                columns: table => new
                {
                    DetailOTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    Hour = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    CarNumber = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Part_PaetID = table.Column<int>(nullable: false),
                    PartID1 = table.Column<int>(nullable: true),
                    FoodSet_FoodSetID = table.Column<int>(nullable: false),
                    FoodSetID1 = table.Column<int>(nullable: true),
                    CarType_CarTypeID = table.Column<int>(nullable: false),
                    CarTypeID1 = table.Column<int>(nullable: true),
                    OT_OTID = table.Column<int>(nullable: false),
                    OTID1 = table.Column<int>(nullable: true),
                    Employee_EmpID = table.Column<int>(nullable: false),
                    EmployeeID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailOT", x => x.DetailOTID);
                    table.ForeignKey(
                        name: "FK_DetailOT_CarType_CarTypeID1",
                        column: x => x.CarTypeID1,
                        principalTable: "CarType",
                        principalColumn: "CarTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_Employee_EmployeeID1",
                        column: x => x.EmployeeID1,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_FoodSet_FoodSetID1",
                        column: x => x.FoodSetID1,
                        principalTable: "FoodSet",
                        principalColumn: "FoodSetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_OT_OTID1",
                        column: x => x.OTID1,
                        principalTable: "OT",
                        principalColumn: "OTID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_Part_PartID1",
                        column: x => x.PartID1,
                        principalTable: "Part",
                        principalColumn: "PartID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GradeHistory_Cock",
                columns: table => new
                {
                    GradeHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GrahAllPoint = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    GrahRound1 = table.Column<int>(nullable: false),
                    GrahRound2 = table.Column<int>(nullable: false),
                    GrahRound3 = table.Column<int>(nullable: false),
                    GrahYear = table.Column<string>(nullable: true),
                    GrahBonusUp = table.Column<int>(nullable: false),
                    GrahSalaryUp = table.Column<int>(nullable: false),
                    GradeHistory_EmployeeID = table.Column<int>(nullable: false),
                    EmployeeID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeHistory_Cock", x => x.GradeHistoryID);
                    table.ForeignKey(
                        name: "FK_GradeHistory_Cock_Employee_EmployeeID1",
                        column: x => x.EmployeeID1,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    LoginID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Login_EmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.LoginID);
                    table.ForeignKey(
                        name: "FK_Login_Employee_Login_EmployeeID",
                        column: x => x.Login_EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UpdateNetwork",
                columns: table => new
                {
                    UpdateNetworkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    IpAddr = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UpdateNetwork_EmployeeID = table.Column<int>(nullable: false),
                    EmployeeID1 = table.Column<int>(nullable: true),
                    UpdateNetwork_NetworkID = table.Column<int>(nullable: false),
                    NetworkID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateNetwork", x => x.UpdateNetworkID);
                    table.ForeignKey(
                        name: "FK_UpdateNetwork_Employee_EmployeeID1",
                        column: x => x.EmployeeID1,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateNetwork_Network_NetworkID1",
                        column: x => x.NetworkID1,
                        principalTable: "Network",
                        principalColumn: "NetworkID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JoinAssetEmp_Cock",
                columns: table => new
                {
                    JoinAssetEmp_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Note = table.Column<string>(nullable: true),
                    Strint = table.Column<string>(nullable: true),
                    JoinAssetEmp_Cock_EmployeeID = table.Column<int>(nullable: false),
                    EmployeeIDEmployee_CockID = table.Column<int>(nullable: true),
                    JoinAssetEmp_Cock_AssetID = table.Column<int>(nullable: false),
                    AssetIDAsset_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinAssetEmp_Cock", x => x.JoinAssetEmp_CockID);
                    table.ForeignKey(
                        name: "FK_JoinAssetEmp_Cock_Asset_Cock_AssetIDAsset_CockID",
                        column: x => x.AssetIDAsset_CockID,
                        principalTable: "Asset_Cock",
                        principalColumn: "Asset_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JoinAssetEmp_Cock_Employee_Cock_EmployeeIDEmployee_CockID",
                        column: x => x.EmployeeIDEmployee_CockID,
                        principalTable: "Employee_Cock",
                        principalColumn: "Employee_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Report_Cock",
                columns: table => new
                {
                    Report_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Report_Cock_EmployeeID = table.Column<int>(nullable: false),
                    EmployeeIDEmployee_CockID = table.Column<int>(nullable: true),
                    Report_Cock_AssetID = table.Column<int>(nullable: false),
                    AssetIDAsset_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report_Cock", x => x.Report_CockID);
                    table.ForeignKey(
                        name: "FK_Report_Cock_Asset_Cock_AssetIDAsset_CockID",
                        column: x => x.AssetIDAsset_CockID,
                        principalTable: "Asset_Cock",
                        principalColumn: "Asset_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Report_Cock_Employee_Cock_EmployeeIDEmployee_CockID",
                        column: x => x.EmployeeIDEmployee_CockID,
                        principalTable: "Employee_Cock",
                        principalColumn: "Employee_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetJoinNetworks",
                columns: table => new
                {
                    AssetJoinNetworkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    AssetJoinNetwork_NetworkID = table.Column<int>(nullable: false),
                    NetworkID1 = table.Column<int>(nullable: true),
                    AssetJoinNetwork_AssetID = table.Column<int>(nullable: false),
                    AssetID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetJoinNetworks", x => x.AssetJoinNetworkID);
                    table.ForeignKey(
                        name: "FK_AssetJoinNetworks_Asset_AssetID1",
                        column: x => x.AssetID1,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetJoinNetworks_Network_NetworkID1",
                        column: x => x.NetworkID1,
                        principalTable: "Network",
                        principalColumn: "NetworkID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JoinAssetEmp",
                columns: table => new
                {
                    JoinAssetEmpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    JoinAssetEmp_EmployeeID = table.Column<int>(nullable: false),
                    EmployeeID1 = table.Column<int>(nullable: true),
                    JoinAssetEmp_AssetID = table.Column<int>(nullable: false),
                    AssetID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinAssetEmp", x => x.JoinAssetEmpID);
                    table.ForeignKey(
                        name: "FK_JoinAssetEmp_Asset_AssetID1",
                        column: x => x.AssetID1,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JoinAssetEmp_Employee_EmployeeID1",
                        column: x => x.EmployeeID1,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JoinLicenseAsset",
                columns: table => new
                {
                    JoinLicenseAssetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true),
                    JoinLicenseAsset_License = table.Column<int>(nullable: false),
                    LicenseID1 = table.Column<int>(nullable: true),
                    JoinLicenseAsset_AssetID = table.Column<int>(nullable: false),
                    AssetID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinLicenseAsset", x => x.JoinLicenseAssetID);
                    table.ForeignKey(
                        name: "FK_JoinLicenseAsset_Asset_AssetID1",
                        column: x => x.AssetID1,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JoinLicenseAsset_License_LicenseID1",
                        column: x => x.LicenseID1,
                        principalTable: "License",
                        principalColumn: "LicenseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Relationship",
                columns: table => new
                {
                    RelationshipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Relationship_AssetIDmom = table.Column<int>(nullable: false),
                    AssetIDmomAssetID = table.Column<int>(nullable: true),
                    Relationship_AssetIDson = table.Column<int>(nullable: false),
                    AssetIDsonAssetID = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship", x => x.RelationshipID);
                    table.ForeignKey(
                        name: "FK_Relationship_Asset_AssetIDmomAssetID",
                        column: x => x.AssetIDmomAssetID,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relationship_Asset_AssetIDsonAssetID",
                        column: x => x.AssetIDsonAssetID,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Report_EmployeeID = table.Column<int>(nullable: false),
                    EmployeeID1 = table.Column<int>(nullable: true),
                    Report_AssetID = table.Column<int>(nullable: false),
                    AssetID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_Report_Asset_AssetID1",
                        column: x => x.AssetID1,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Report_Employee_EmployeeID1",
                        column: x => x.EmployeeID1,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UpdateAsset",
                columns: table => new
                {
                    UpdateAssetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetName = table.Column<string>(nullable: true),
                    SerailNumber = table.Column<string>(nullable: true),
                    MACAddr = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    PONumber = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    UpdateAsset_LocationID = table.Column<int>(nullable: false),
                    LocationID1 = table.Column<int>(nullable: true),
                    UpdateAsset_CompanyID = table.Column<int>(nullable: false),
                    CompanyID1 = table.Column<int>(nullable: true),
                    UpdateAsset_SepartmentID = table.Column<int>(nullable: false),
                    SepartmentIDDepartmentID = table.Column<int>(nullable: true),
                    UpdateAsset_SupplierID = table.Column<int>(nullable: false),
                    SupplierID1 = table.Column<int>(nullable: true),
                    UpdateAsset_EmployeeID = table.Column<int>(nullable: false),
                    EmployeeID1 = table.Column<int>(nullable: true),
                    UpdateAsset_AssetID = table.Column<int>(nullable: false),
                    AssetID1 = table.Column<int>(nullable: true),
                    UpdateAsset_ModelID = table.Column<int>(nullable: false),
                    ModelID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateAsset", x => x.UpdateAssetID);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Asset_AssetID1",
                        column: x => x.AssetID1,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Company_CompanyID1",
                        column: x => x.CompanyID1,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Employee_EmployeeID1",
                        column: x => x.EmployeeID1,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Location_LocationID1",
                        column: x => x.LocationID1,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Model_ModelID1",
                        column: x => x.ModelID1,
                        principalTable: "Model",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Department_SepartmentIDDepartmentID",
                        column: x => x.SepartmentIDDepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Supplier_SupplierID1",
                        column: x => x.SupplierID1,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Repair_Cock",
                columns: table => new
                {
                    Repair_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Repair_Cock_EmployeeID = table.Column<int>(nullable: false),
                    EmployeeIDEmployee_CockID = table.Column<int>(nullable: true),
                    Repair_Cock_ReportID = table.Column<int>(nullable: false),
                    ReportIDReport_CockID = table.Column<int>(nullable: true),
                    Repair_Cock_AssetID = table.Column<int>(nullable: false),
                    AssetIDAsset_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repair_Cock", x => x.Repair_CockID);
                    table.ForeignKey(
                        name: "FK_Repair_Cock_Asset_Cock_AssetIDAsset_CockID",
                        column: x => x.AssetIDAsset_CockID,
                        principalTable: "Asset_Cock",
                        principalColumn: "Asset_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repair_Cock_Employee_Cock_EmployeeIDEmployee_CockID",
                        column: x => x.EmployeeIDEmployee_CockID,
                        principalTable: "Employee_Cock",
                        principalColumn: "Employee_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repair_Cock_Report_Cock_ReportIDReport_CockID",
                        column: x => x.ReportIDReport_CockID,
                        principalTable: "Report_Cock",
                        principalColumn: "Report_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Repair",
                columns: table => new
                {
                    RepairID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Repair_EmployeeID = table.Column<int>(nullable: false),
                    EmployeeID1 = table.Column<int>(nullable: true),
                    Repair_ReportID = table.Column<int>(nullable: false),
                    ReportID1 = table.Column<int>(nullable: true),
                    Repair_AssetID = table.Column<int>(nullable: false),
                    AssetID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repair", x => x.RepairID);
                    table.ForeignKey(
                        name: "FK_Repair_Asset_AssetID1",
                        column: x => x.AssetID1,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repair_Employee_EmployeeID1",
                        column: x => x.EmployeeID1,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repair_Report_ReportID1",
                        column: x => x.ReportID1,
                        principalTable: "Report",
                        principalColumn: "ReportID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_CompanyID1",
                table: "Asset",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_DepartmentID1",
                table: "Asset",
                column: "DepartmentID1");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_EmployeeID1",
                table: "Asset",
                column: "EmployeeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_LocationID1",
                table: "Asset",
                column: "LocationID1");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_ModelID1",
                table: "Asset",
                column: "ModelID1");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_SupplierID1",
                table: "Asset",
                column: "SupplierID1");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Cock_CompanyIDCompany_CockID",
                table: "Asset_Cock",
                column: "CompanyIDCompany_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Cock_DepartmentIDDepartment_CockID",
                table: "Asset_Cock",
                column: "DepartmentIDDepartment_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Cock_EmployeeIDEmployee_CockID",
                table: "Asset_Cock",
                column: "EmployeeIDEmployee_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Cock_SupplierIDSupplier_CockID",
                table: "Asset_Cock",
                column: "SupplierIDSupplier_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_AssetJoinNetworks_AssetID1",
                table: "AssetJoinNetworks",
                column: "AssetID1");

            migrationBuilder.CreateIndex(
                name: "IX_AssetJoinNetworks_NetworkID1",
                table: "AssetJoinNetworks",
                column: "NetworkID1");

            migrationBuilder.CreateIndex(
                name: "IX_CarType_CompanyCarID1",
                table: "CarType",
                column: "CompanyCarID1");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_CarTypeID1",
                table: "DetailOT",
                column: "CarTypeID1");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_EmployeeID1",
                table: "DetailOT",
                column: "EmployeeID1");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_FoodSetID1",
                table: "DetailOT",
                column: "FoodSetID1");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_OTID1",
                table: "DetailOT",
                column: "OTID1");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_PartID1",
                table: "DetailOT",
                column: "PartID1");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Cock_CarTypeIDCarType_CockID",
                table: "DetailOT_Cock",
                column: "CarTypeIDCarType_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Cock_EmployeeIDEmployee_CockID",
                table: "DetailOT_Cock",
                column: "EmployeeIDEmployee_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Cock_FoodSetIDFoodSet_CockID",
                table: "DetailOT_Cock",
                column: "FoodSetIDFoodSet_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Cock_OTIDOT_CockID",
                table: "DetailOT_Cock",
                column: "OTIDOT_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Cock_PartIDPart_CockID",
                table: "DetailOT_Cock",
                column: "PartIDPart_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CompanyID1",
                table: "Employee",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentID1",
                table: "Employee",
                column: "DepartmentID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeTypeID1",
                table: "Employee",
                column: "EmployeeTypeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EvaluationID1",
                table: "Employee",
                column: "EvaluationID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_GradeHistoryID1",
                table: "Employee",
                column: "GradeHistoryID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_LocationID1",
                table: "Employee",
                column: "LocationID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PositionID1",
                table: "Employee",
                column: "PositionID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cock_CompanyIDCompany_CockID",
                table: "Employee_Cock",
                column: "CompanyIDCompany_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cock_DepartmentIDDepartment_CockID",
                table: "Employee_Cock",
                column: "DepartmentIDDepartment_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cock_EmployeeTypeIDEmployeeType_CockID",
                table: "Employee_Cock",
                column: "EmployeeTypeIDEmployeeType_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cock_LocationID1",
                table: "Employee_Cock",
                column: "LocationID1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cock_PositionIDPosition_CockID",
                table: "Employee_Cock",
                column: "PositionIDPosition_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_GradeHistoryID1",
                table: "Evaluation",
                column: "GradeHistoryID1");

            migrationBuilder.CreateIndex(
                name: "IX_FoodSet_CanteenID1",
                table: "FoodSet",
                column: "CanteenID1");

            migrationBuilder.CreateIndex(
                name: "IX_GradeHistory_Cock_EmployeeID1",
                table: "GradeHistory_Cock",
                column: "EmployeeID1");

            migrationBuilder.CreateIndex(
                name: "IX_JoinAssetEmp_AssetID1",
                table: "JoinAssetEmp",
                column: "AssetID1");

            migrationBuilder.CreateIndex(
                name: "IX_JoinAssetEmp_EmployeeID1",
                table: "JoinAssetEmp",
                column: "EmployeeID1");

            migrationBuilder.CreateIndex(
                name: "IX_JoinAssetEmp_Cock_AssetIDAsset_CockID",
                table: "JoinAssetEmp_Cock",
                column: "AssetIDAsset_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_JoinAssetEmp_Cock_EmployeeIDEmployee_CockID",
                table: "JoinAssetEmp_Cock",
                column: "EmployeeIDEmployee_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_JoinLicenseAsset_AssetID1",
                table: "JoinLicenseAsset",
                column: "AssetID1");

            migrationBuilder.CreateIndex(
                name: "IX_JoinLicenseAsset_LicenseID1",
                table: "JoinLicenseAsset",
                column: "LicenseID1");

            migrationBuilder.CreateIndex(
                name: "IX_License_CompanyID1",
                table: "License",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_License_DepartmentID1",
                table: "License",
                column: "DepartmentID1");

            migrationBuilder.CreateIndex(
                name: "IX_License_ModelID1",
                table: "License",
                column: "ModelID1");

            migrationBuilder.CreateIndex(
                name: "IX_License_SupplierID1",
                table: "License",
                column: "SupplierID1");

            migrationBuilder.CreateIndex(
                name: "IX_Login_Login_EmployeeID",
                table: "Login",
                column: "Login_EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Model_BrandID1",
                table: "Model",
                column: "BrandID1");

            migrationBuilder.CreateIndex(
                name: "IX_Model_CategoryID1",
                table: "Model",
                column: "CategoryID1");

            migrationBuilder.CreateIndex(
                name: "IX_Point_PartID1",
                table: "Point",
                column: "PartID1");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship_AssetIDmomAssetID",
                table: "Relationship",
                column: "AssetIDmomAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship_AssetIDsonAssetID",
                table: "Relationship",
                column: "AssetIDsonAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_AssetID1",
                table: "Repair",
                column: "AssetID1");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_EmployeeID1",
                table: "Repair",
                column: "EmployeeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_ReportID1",
                table: "Repair",
                column: "ReportID1");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_Cock_AssetIDAsset_CockID",
                table: "Repair_Cock",
                column: "AssetIDAsset_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_Cock_EmployeeIDEmployee_CockID",
                table: "Repair_Cock",
                column: "EmployeeIDEmployee_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_Cock_ReportIDReport_CockID",
                table: "Repair_Cock",
                column: "ReportIDReport_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_AssetID1",
                table: "Report",
                column: "AssetID1");

            migrationBuilder.CreateIndex(
                name: "IX_Report_EmployeeID1",
                table: "Report",
                column: "EmployeeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Report_Cock_AssetIDAsset_CockID",
                table: "Report_Cock",
                column: "AssetIDAsset_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_Cock_EmployeeIDEmployee_CockID",
                table: "Report_Cock",
                column: "EmployeeIDEmployee_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_AssetID1",
                table: "UpdateAsset",
                column: "AssetID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_CompanyID1",
                table: "UpdateAsset",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_EmployeeID1",
                table: "UpdateAsset",
                column: "EmployeeID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_LocationID1",
                table: "UpdateAsset",
                column: "LocationID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_ModelID1",
                table: "UpdateAsset",
                column: "ModelID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_SepartmentIDDepartmentID",
                table: "UpdateAsset",
                column: "SepartmentIDDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_SupplierID1",
                table: "UpdateAsset",
                column: "SupplierID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateLicense_CompanyID1",
                table: "UpdateLicense",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateLicense_DepartmentID1",
                table: "UpdateLicense",
                column: "DepartmentID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateLicense_LicenseID1",
                table: "UpdateLicense",
                column: "LicenseID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateLicense_ModelID1",
                table: "UpdateLicense",
                column: "ModelID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateLicense_SupplierID1",
                table: "UpdateLicense",
                column: "SupplierID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateNetwork_EmployeeID1",
                table: "UpdateNetwork",
                column: "EmployeeID1");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateNetwork_NetworkID1",
                table: "UpdateNetwork",
                column: "NetworkID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetJoinNetworks");

            migrationBuilder.DropTable(
                name: "DetailOT");

            migrationBuilder.DropTable(
                name: "DetailOT_Cock");

            migrationBuilder.DropTable(
                name: "GradeHistory_Cock");

            migrationBuilder.DropTable(
                name: "JoinAssetEmp");

            migrationBuilder.DropTable(
                name: "JoinAssetEmp_Cock");

            migrationBuilder.DropTable(
                name: "JoinLicenseAsset");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Point");

            migrationBuilder.DropTable(
                name: "Relationship");

            migrationBuilder.DropTable(
                name: "Repair");

            migrationBuilder.DropTable(
                name: "Repair_Cock");

            migrationBuilder.DropTable(
                name: "UpdateAsset");

            migrationBuilder.DropTable(
                name: "UpdateLicense");

            migrationBuilder.DropTable(
                name: "UpdateNetwork");

            migrationBuilder.DropTable(
                name: "CarType");

            migrationBuilder.DropTable(
                name: "FoodSet");

            migrationBuilder.DropTable(
                name: "OT");

            migrationBuilder.DropTable(
                name: "CarType_Cock");

            migrationBuilder.DropTable(
                name: "FoodSet_Cock");

            migrationBuilder.DropTable(
                name: "OT_Cock");

            migrationBuilder.DropTable(
                name: "Part_Cock");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Report_Cock");

            migrationBuilder.DropTable(
                name: "License");

            migrationBuilder.DropTable(
                name: "Network");

            migrationBuilder.DropTable(
                name: "CompanyCar");

            migrationBuilder.DropTable(
                name: "Canteen");

            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "Asset_Cock");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Employee_Cock");

            migrationBuilder.DropTable(
                name: "Supplier_Cock");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Company_Cock");

            migrationBuilder.DropTable(
                name: "Department_Cock");

            migrationBuilder.DropTable(
                name: "EmployeeType_Cock");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Position_Cock");

            migrationBuilder.DropTable(
                name: "GradeHistory");
        }
    }
}
