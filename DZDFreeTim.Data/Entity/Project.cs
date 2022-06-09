using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DZDFreeTim.Data.Entity
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [ForeignKey("Bank")]//BankId?
        public int BankId { get; set; }

        [Required]
        [Column(TypeName = "nvharchar(50)")]
        public string ProjectName { get; set; }

        [Required]
        [Column(TypeName = "nvharchar(50)")]
        public string JiraProjectNo { get; set; }

        [Required]
        [Column(TypeName = "nvharchar(50)")]
        public string JiraTaskNo { get; set; }

        [Required]
        public int priority { get; set; }

        [ForeignKey("DzdStatus")]
        public int DzdStatus { get; set; }

        [ForeignKey("JiraStatus")]
        public int JiraStatus { get; set; }

        [ForeignKey("Employee")]
        public int AnalystId { get; set; }

        [ForeignKey("Employee")]
        public int DeveloperId { get; set; }

        [ForeignKey("IntertechTeam")]
        public int AnalystId { get; set; }

        [Required]
        public int Effort { get; set; }

        [Column(TypeName = "nvharchar(50)")]
        public string Notes { get; set; }

        public int InvNumber { get; set; }

        
        [Column(TypeName = "nvharchar(8)")]
        public string BillYearQuarter{ get; set; }
    }
}
