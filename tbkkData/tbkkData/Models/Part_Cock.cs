using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class Part_Cock
    {
        [Key]
        public int Part_CockID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
