﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ColorDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string Name { get; set; }
        [Required]
        [StringLength(9)]
        public string ColorCode { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
