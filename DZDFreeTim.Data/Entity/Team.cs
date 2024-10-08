﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DZDFreeTim.Data.Entity.Abstract;

namespace DZDFreeTim.Data.Entity
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required]
        [StringLength(50)]
        public string TeamName { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
    }
}
