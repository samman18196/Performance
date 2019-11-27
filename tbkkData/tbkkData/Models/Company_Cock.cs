using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class Company_Cock
    {
        [Key]
        public int Company_CockID { get; set; }
        public string CompanyName { get; set; }
        public string Status { get; set; }

    }
}
