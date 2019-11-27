using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Asset
    {
        [Key]
        public int AssetID { get; set; }
        public string AssetName { get; set; }
        public string SerailNumber { get; set; }
        public string MACAddr { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime InstallDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime PurchaseDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime ExpireDate { get; set; }
        public string PONumber { get; set; }
        public double Price { get; set; }
        public string Warranty { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }

        [ForeignKey("Location")]
        public int Asset_LocationID { get; set; }
        public Location LocationID { get; set; }

        [ForeignKey("Company")]
        public int Asset_CompanyID { get; set; }
        public Company CompanyID { get; set; }

        [ForeignKey("Department")]
        public int Asset_DepartmentID { get; set; }
        public Department DepartmentID { get; set; }

        [ForeignKey("Supplier")]
        public int Asset_SupplierID { get; set; }
        public Supplier SupplierID { get; set; }

        [ForeignKey("Employee")]
        public int Asset_EmployeeID { get; set; }
        public Employee EmployeeID { get; set; }

        [ForeignKey("Model")]
        public int Asset_ModelID { get; set; }
        public Model ModelID { get; set; }
    }
}
