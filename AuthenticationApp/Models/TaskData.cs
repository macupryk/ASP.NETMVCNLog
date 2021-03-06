﻿using AuthenticationApp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticationApp.Models
{

    public class TaskData
    {
        [Key]
        public Guid TaskId { get; set; }
        public string UserId { get; set; }
        public USER_TYPE UserType { get; set; }
        public string CustomerId { get; set; }
        public string VenderId { get; set; }
        public States StateId { get; set; }
        public string StateName { get; set; }
        [Required]
        public int PartNumberRevision { get; set; }
        [Required]
        public MATERIALS_CATEGORY MaterialCategory { get; set; }
        [Required]
        public MATERIALS_TYPE Material { get; set; }
  
        public MATERIALS_Main_Types MaterialMainType { get; set; }

        public MATERIALS_Processes Process { get; set; }
        public MATERIALS_TYPE_Precision_Metals_Surface_Finish SurfaceFinish { get; set; }
        public MATERIALS_TYPE_Membrane_Switches_Attributes SwitchesAttributes { get; set; }
        public MATERIALS_TYPE_Graphic_Overlays_Attributes OverlaysAttributes { get; set; }
        
        [Required]
        public QUANTITY_BREAKS QuantityBreak { get; set; }
      
        public LeadTimeFromNowInMonth LeadTime { get; set; }
        [Required]
        public FILE_TYPE FileType { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreateTC { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime UpdateTC { get; set; }

        public string UpdateBy { get; set; }

    }
}