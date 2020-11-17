using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;                // [Key]
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Grids.Models
{
    public class Fund
    {
        internal readonly int FundId;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FundStructureId { get; set; } = 0;
        public string FundName { get; set; } = "";
        public string LaunchDate { get; set; } = "";
    }
}
