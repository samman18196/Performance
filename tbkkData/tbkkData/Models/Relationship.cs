using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Relationship
    {
        [Key]
        public int RelationshipID { get; set; }

        [ForeignKey("Asset")]
        public int Relationship_AssetIDmom { get; set; }
        public Asset AssetIDmom { get; set; }

        [ForeignKey("Asset")]
        public int Relationship_AssetIDson { get; set; }
        public  Asset AssetIDson { get; set; }

        public string Status { get; set; }
    }
}
