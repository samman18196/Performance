using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class Position_Cock
    {
        [Key]
        public int Position_CockID { get; set; }
        public string PositionName { get; set; }
    }
}
