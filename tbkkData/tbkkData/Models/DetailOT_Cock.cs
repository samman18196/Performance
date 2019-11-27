using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class DetailOT_Cock
    {
        [Key]
        public int DetailOT_CockID { get; set; }
        public double Hour { get; set; }
        public string Type { get; set; }
        public int CarNumber { get; set; }
        public string Status { get; set; }

        [ForeignKey("Part")]
        public int Part_Cock_PaetID { get; set; }
        public Part_Cock PartID { get; set; }

        [ForeignKey("FoodSet")]
        public int FoodSet_Cock_FoodSetID { get; set; }
        public FoodSet_Cock FoodSetID { get; set; }

        [ForeignKey("CarType")]
        public int CarType_Cock_CarTypeID { get; set; }
        public CarType_Cock CarTypeID { get; set; }

        [ForeignKey("OT")]
        public int OT_Cock_OTID { get; set; }
        public OT_Cock OTID { get; set; }


        [ForeignKey("Employee")]
        public int Employee_Cock_EmpID { get; set; }
        public Employee_Cock EmployeeID { get; set; }
    }
}
