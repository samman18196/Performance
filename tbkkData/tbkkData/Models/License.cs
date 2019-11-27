using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class License
    {
        [Key]
        public int LicenseID { get; set; }
        public string LicenseName { get; set; }
        public string SoftewareName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime PurchaseDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime ExpireDate { get; set; }
        public string PONumber { get; set; }
        public string Attachfiles { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }


        [ForeignKey("Model")]
        public int License_ModelID { get; set; }
        public Model ModelID { get; set; }

        [ForeignKey("Supplier")]
        public int License_SupplierID { get; set; }
        public Supplier SupplierID { get; set; }

        [ForeignKey("Department")]
        public int License_DepartmentID { get; set; }
        public Department DepartmentID { get; set; }

        [ForeignKey("Company")]
        public int License_CompanyID { get; set; }
        public Company CompanyID { get; set; }
    }
}
