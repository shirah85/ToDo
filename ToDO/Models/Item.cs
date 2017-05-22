﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDO.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        [Required, MinLength(2) Display(Name ="Item")]
        public string ItemName { get; set; }
        //makes due date required
        [Display (Name ="Due Date")] 
        public DateTime DueDate { get; set; }
        [MaxLength(500),MinLength(30)]
        public string Details { get; set; }
        public bool IsDone { get; set;  }
        
        [ForeignKey("List")] 
        public int ListID { get; set; }
        public virtual List List { get; set; }          
    }
}