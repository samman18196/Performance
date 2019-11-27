using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class CarType_Cock
    {
        [Key]
        public int CarType_CockID { get; set; }
        public int CerNumber { get; set; }
        public string NameCar { get; set; }
        
    }
}
