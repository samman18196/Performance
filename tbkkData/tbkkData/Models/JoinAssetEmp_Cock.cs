using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class JoinAssetEmp_Cock
    {
        [Key]
        public int JoinAssetEmp_CockID { get; set; }
        public string Note { get; set; }
        public string Strint { get; set; }
        [ForeignKey("Employee")]
        public int JoinAssetEmp_Cock_EmployeeID { get; set; }
        public Employee_Cock EmployeeID { get; set; }


        [ForeignKey("Asset")]
        public int JoinAssetEmp_Cock_AssetID { get; set; }
        public Asset_Cock AssetID { get; set; }
    }
}
