using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Villa_resort.Domain.Entities
{
    public class VillaModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public Int32 Occupancy { get; set; }
        [Display (Name="Price per night")]
        public double Price { get; set; }
        public Int32 Sqft { get; set; }
        [Display(Name = "Image_URL")]
        public string? ImageUrl { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;

        

    }
}
