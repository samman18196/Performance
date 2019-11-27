using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class EmployeeType_Cock
    {
        [Key]
        public int EmployeeType_CockID { get; set; }
        public string EmployeeTypeName { get; set; }
    }
}
