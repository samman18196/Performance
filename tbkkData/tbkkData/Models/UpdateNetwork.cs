using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class UpdateNetwork
    {
        [Key]
        public int UpdateNetworkID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime Date { get; set; }
        public string IpAddr { get; set; }
        public string Note { get; set; }
        public string Password { get; set; }

        [ForeignKey("Employee")]
        public int UpdateNetwork_EmployeeID { get; set; }
        public Employee EmployeeID { get; set; }

        [ForeignKey("Network")]
        public int UpdateNetwork_NetworkID { get; set; }
        public Network NetworkID { get; set; }

    }
}
