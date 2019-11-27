using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string Note { get; set; }
    }
}
