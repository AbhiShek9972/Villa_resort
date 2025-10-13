using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa_resort.Domain.Entities
{
    public class VillaNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int villaNumber { get; set; }

        [ForeignKey("VillaModel")]
        public int VillaID { get; set; }
        public VillaModel VillaModel { get; set; }
        public string ? SpecialDetails { get; set; }

    }
}
