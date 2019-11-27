using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace tbkkData.Models
{
    public class UpdateAsset
    {
        [Key]
        public int UpdateAssetID { get; set; }
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
        public int Warranty { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }

        [ForeignKey("Location")]
        public int UpdateAsset_LocationID { get; set; }
        public Location LocationID { get; set; }

        [ForeignKey("Company")]
        public int UpdateAsset_CompanyID { get; set; }
        public Company CompanyID { get; set; }

        [ForeignKey("Department")]
        public int UpdateAsset_SepartmentID { get; set; }
        public Department SepartmentID { get; set; }

        [ForeignKey("Supplier")]
        public int  UpdateAsset_SupplierID { get; set; }
        public Supplier SupplierID { get; set; }

        [ForeignKey("Employee")]
        public int UpdateAsset_EmployeeID { get; set; }
        public Employee EmployeeID { get; set; }

        [ForeignKey("Asset")]
        public int  UpdateAsset_AssetID { get; set; }
        public Asset AssetID { get; set; }

        [ForeignKey("Model")]
        public int  UpdateAsset_ModelID { get; set; }
        public Model ModelID { get; set; }
    }
}
