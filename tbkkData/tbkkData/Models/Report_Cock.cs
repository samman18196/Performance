using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class Report_Cock
    {
        [Key]
        public int Report_CockID { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        [ForeignKey("Employee")]
        public int Report_Cock_EmployeeID { get; set; }
        public Employee_Cock EmployeeID { get; set; }

        [ForeignKey("Asset")]
        public int Report_Cock_AssetID { get; set; }
        public Asset_Cock AssetID { get; set; }
    }
}
