using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class UpdateLicense
    {
        [Key]
        public int UpdateLicenseID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime Date { get; set; }
        public string LicenseName { get; set; }
        public string SoftwareName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime PurchaseDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime ExpireDate { get; set; }
        public string PONumber { get; set; }
        public string Attachfiles { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }

        [ForeignKey("Model")]
        public int UpdateLicense_ModelID { get; set; }
        public Model ModelID { get; set; }

        [ForeignKey("Supplier")]
        public int UpdateLicense_SupplierID { get; set; }
        public Supplier SupplierID { get; set; }

        [ForeignKey("Department")]
        public int UpdateLicense_DepartmentID { get; set; }
        public Department DepartmentID { get; set; }

        [ForeignKey("Company")]
        public int UpdateLicense_CompanyID { get; set; }
        public Company CompanyID { get; set; }

        [ForeignKey("License")]
        public int UpdateLicense_LicenseID { get; set; }
        public License LicenseID { get; set; }
    }
}
