using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace tbkkData.Models
{
    public class Repair
    {
        [Key]
        public int RepairID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        [ForeignKey("Employee")]
        public int Repair_EmployeeID { get; set; }
        public Employee EmployeeID { get; set; }

        [ForeignKey("Report")]
        public int Repair_ReportID { get; set; }
        public Report ReportID { get; set; }

        [ForeignKey("Asset")]
        public int Repair_AssetID { get; set; }
        public Asset AssetID { get; set; }
    }
}
