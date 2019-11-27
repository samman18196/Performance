using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Network
    {
        [Key]
        public int NetworkID { get; set; }
        public string NetworkName { get; set; }
        public string IpAddr { get; set; }
        public string Note { get; set; }
        public string Password { get; set; }
    }
}
