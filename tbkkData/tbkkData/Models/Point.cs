using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace tbkkData.Models
{
    public class Point
    {
        [Key]
        public int PointID { get; set; }
        public string NamePoint { get; set; }

        [ForeignKey("Part")]
        public int Point_PartID { get; set; }
        public Part PartID { get; set; }
    }
}
