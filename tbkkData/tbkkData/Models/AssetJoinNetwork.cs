using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class AssetJoinNetwork
    {
        [Key]
        public int AssetJoinNetworkID { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }

        [ForeignKey("Network")]
        public int AssetJoinNetwork_NetworkID { get; set; }
        public Network NetworkID { get; set; }

        [ForeignKey("Asset")]
        public int AssetJoinNetwork_AssetID { get; set; }
        public Asset AssetID { get; set; }
    }
}
