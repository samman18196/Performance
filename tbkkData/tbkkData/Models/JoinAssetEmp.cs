using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class JoinAssetEmp
    {
        [Key]
        public int JoinAssetEmpID { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }

        [ForeignKey("Employee")]
        public int JoinAssetEmp_EmployeeID { get; set; }
        public Employee EmployeeID { get; set; }


        [ForeignKey("Asset")]
        public int JoinAssetEmp_AssetID { get; set; }
        public Asset AssetID { get; set; }
    }
}
