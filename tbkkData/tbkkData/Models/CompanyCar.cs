using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class CompanyCar
    {
        [Key]
        public int CompanyCarID { get; set; }

        public string NameCompanyCar { get; set; }

        public string Seat { get; set; }
        public string Line { get; set; }
        public string Call { get; set; }
        public string Status { get; set; }
    }
}

