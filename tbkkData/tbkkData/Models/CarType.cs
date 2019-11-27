using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class CarType
    {
        [Key]
        public int CarTypeID { get; set; }

        public string NameCar { get; set; }

        public string Seat { get; set; }

        [ForeignKey("CompanyCar")]
        public int CarType_CompanyCarID { get; set; }
        public CompanyCar CompanyCarID { get; set; }

    }
}
