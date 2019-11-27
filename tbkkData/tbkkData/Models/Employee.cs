using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Line { get; set; }
        public string Call { get; set; }
        public string Addr { get; set; }
        public string Image { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime Date { get; set; }
        public string Status { get; set; }



        [ForeignKey("Company")]
        public int Employee_CompanyID { get; set; }
        public Company CompanyID { get; set; }


        [ForeignKey("Department")]
        public int Employee_DepartmentNameID { get; set; }

        public Department DepartmentID { get; set; }



        [ForeignKey("Location")]
        public int Employee_LocationID { get; set; }
        public Location LocationID { get; set; }



        [ForeignKey("EmployeeType")]
        public int Employee_EmployeeTypeID { get; set; }
        public EmployeeType EmployeeTypeID { get; set; }


        [ForeignKey("Position")]
        public int Employee_PositionID { get; set; }
        public Position PositionID { get; set; }
    }
}
