﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.BL.DTOs
{
    public class CourseDTO
    {
        [Required(ErrorMessage = "The field course ID is required")]
        public int CourseID { get; set; }
        [Required(ErrorMessage = "The field Title ID is required")]
        [StringLength(50)]
        public string Title { get; set; }
        [Required(ErrorMessage = "The field Credits ID is required")]
        public int Credits { get; set; }
    }
}
