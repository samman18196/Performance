using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class GradeHistory_Cock
    {
        [Key]
        public int GradeHistoryID { get; set; }
        public int GrahAllPoint { get; set; }
        public int Count { get; set; }
        public int GrahRound1 { get; set; }
        public int GrahRound2 { get; set; }
        public int GrahRound3 { get; set; }
        public string GrahYear { get; set; }

        public int GrahBonusUp { get; set; }

        public int GrahSalaryUp { get; set; }

        [ForeignKey("Employee")]
        public int GradeHistory_EmployeeID { get; set; }
        public virtual Employee EmployeeID { get; set; }
    }
}
