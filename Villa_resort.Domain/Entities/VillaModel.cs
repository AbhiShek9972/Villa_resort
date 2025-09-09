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

        [Required (ErrorMessage="Please Enter Name")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please Enter Price")]
        [Display(Name = "Price per night")]
        public double ? Price { get; set; }

        [Required(ErrorMessage = "Please Enter Sqft")]
        public Int32 ? Sqft { get; set; }

        [Required(ErrorMessage = "Please Enter Occupancy")]
        public Int32 ? Occupancy { get; set; }

        [Required(ErrorMessage = "Please Enter ImageUrl")]
        [Display(Name = "Image_URL")]
        public string? ImageUrl { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;

    }
}
