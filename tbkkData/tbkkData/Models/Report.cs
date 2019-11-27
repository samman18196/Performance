﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }
        public string Title { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        [ForeignKey("Employee")]
        public int Report_EmployeeID { get; set; }
        public Employee EmployeeID { get; set; }

        [ForeignKey("Asset")]
        public int Report_AssetID { get; set; }
        public Asset AssetID { get; set; }
    }
}
