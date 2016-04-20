﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Solutioneers.Models
{
    public class ProblemModel
    {
        /// <summary>
        /// Two keys indicates composite key.
        /// The below things in brackets "[]" are Data annotations, restricts/limits what variable can do.
        /// Please see here for additional info: "https://msdn.microsoft.com/en-us/data/jj591583.aspx".
        /// </summary>
        [Key]
        public virtual int UID { get; set; } //User ID 
        [Key]
        public virtual int PID { get; set; } //Problem ID
        [Key]
        public virtual int GID { get; set; } //Group ID
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(255)]    // sets max length to 255
        public string Description { get; set; }

    }
}