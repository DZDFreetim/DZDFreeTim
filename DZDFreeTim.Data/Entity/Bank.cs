using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DZDFreeTim.Data.Entity.Abstract;

namespace DZDFreeTim.Data.Entity
{
    public class Bank : IAuditEntity
    {
        [Key]
        public int BankId { get; set; }

        [Required]
        [Column(TypeName = "nvharchar(50)")]
        public string BankName { get; set; }
    }
}
