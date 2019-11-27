using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class FoodSet_Cock
    {
        [Key]
        public int FoodSet_CockID { get; set; }
        public string Manu { get; set; }
        public string NameSet { get; set; }
        
    }
}
