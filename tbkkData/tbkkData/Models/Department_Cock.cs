using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace tbkkData.Model
{
    public class Department_Cock
    {
        [Key]
        public int Department_CockID { get; set; }
        public string DepartmentName { get; set; }
        public string Status { get; set; }
    }
}
