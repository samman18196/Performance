using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class Supplier_Cock
    {
        [Key]
        public int Supplier_CockID { get; set; }
        public string SupplierName { get; set; }
       
    }
}
