using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class Asset_Cock
    {
        [Key]
        public int Asset_CockID { get; set; }
        public string AssetName { get; set; }
        public string SerailNumber { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime InstallDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime ExpireDate { get; set; }
        public double Price { get; set; }
        public int Warranty { get; set; }
        public string Status { get; set; }

        [ForeignKey("Department_Cock")]
        public int Department_Cock { get; set; }
        public Department_Cock DepartmentID { get; set; }

        [ForeignKey("Company_Cock")]
        public int Company_Cock { get; set; }
        public Company_Cock CompanyID { get; set; }

        [ForeignKey("Supplier_Cock")]
        public int Supplier_Cock { get; set; }
        public Supplier_Cock SupplierID { get; set; }

        [ForeignKey("Employee_Cock")]
        public int Employee_Cock { get; set; }
        public Employee_Cock EmployeeID { get; set; }
    }
}
