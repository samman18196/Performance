using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class Repair_Cock
    {
        [Key]
        public int Repair_CockID { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        [ForeignKey("Employee")]
        public int Repair_Cock_EmployeeID { get; set; }
        public Employee_Cock EmployeeID { get; set; }

        [ForeignKey("Report")]
        public int Repair_Cock_ReportID { get; set; }
        public Report_Cock ReportID { get; set; }

        [ForeignKey("Asset")]
        public int Repair_Cock_AssetID { get; set; }
        public Asset_Cock AssetID { get; set; }
    }

}
