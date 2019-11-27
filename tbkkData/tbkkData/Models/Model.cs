using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Model
    {
        [Key]
        public int ModelID { get; set; }
        public string ModelName { get; set; }

        [ForeignKey("Brand")]
        public int Model_BrandID { get; set; }
        public  Brand BrandID { get; set; }

        [ForeignKey("Location")]
        public int Model_CategoryID { get; set; }
        public  Category CategoryID { get; set; }
    }
}
