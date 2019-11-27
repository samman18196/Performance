using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Part
    {
        [Key]
        public int PartID { get; set; }

        public string Name { get; set; }
        public string Price { get; set; }
    }
}
