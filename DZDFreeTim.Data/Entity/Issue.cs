using DZDFreeTim.Data.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data.Entity
{
    public class Issue : BaseEntity
    {

        [Key]
        public int IssueId { get; set; }


        [Required]
        [StringLength(150)]
        public string IssueName { get; set; }

        [ForeignKey("IssueType")]
        public int IssueType { get; set; }

        [ForeignKey("Bank")]
        public int CompanyId { get; set; }

        [Required]
        [StringLength(150)]
        public string Summary { get; set; }


        public int AssigneeId { get; set; }

        [ForeignKey("Reporter")]
        public int ReporterId { get; set; }

        [ForeignKey("Resolution")]
        public int Resolution { get; set; }

        [ForeignKey("Priority")]
        public int Priority { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string Created { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string Resolved{ get; set; }


        [ForeignKey("IssueStatus")]
        public int Status { get; set; }
    }
}