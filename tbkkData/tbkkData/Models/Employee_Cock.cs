using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using tbkkData.Models;

namespace tbkkData.Model
{
    public class Employee_Cock
    {
        public int Employee_CockID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("Company")]
        public int Employee_Cock_CompanyID { get; set; }
        public Company_Cock CompanyID { get; set; }


        [ForeignKey("Department")]
        public int Employee_Cock_DepartmentNameID { get; set; }
        public Department_Cock DepartmentID { get; set; }



        [ForeignKey("Location")]
        public int Employee_Cock_LocationID { get; set; }
        public Location LocationID { get; set; }



        [ForeignKey("EmployeeType")]
        public int Employee_Cock_EmployeeTypeID { get; set; }
        public EmployeeType_Cock EmployeeTypeID { get; set; }


        [ForeignKey("Position")]
        public int Employee_Cock_PositionID { get; set; }
        public Position_Cock PositionID { get; set; }
    }
}

