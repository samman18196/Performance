using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Model
{
    public class OT_Cock
    {
        [Key]
        public int OT_CockID { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime TimeStart { get; set; }


        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]

        public DateTime TimeEnd { get; set; }



        public string TypeOT { get; set; }

        [Display(Name = "TypeStatus")]
        public string TypStatus { get; set; }
    }
}
