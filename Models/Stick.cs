using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megha_Stick.Models
{
    public class Stick
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Brand { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Manufacture Date")]
        public DateTime ManufactureDate { get; set; }

        [Required]
        [StringLength(30)]
        public string Material { get; set; }

        [Required]
        public double Length { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [Required]
        [StringLength(30)]
        public string GripType { get; set; }

        [Required]
        public CustomRatingScale Rating { get; set; }
    }


    public enum CustomRatingScale
    {
        [Display(Name = "Poor")]
        One = 1,

        [Display(Name = "Average")]
        Two = 2,

        [Display(Name = "Fine")]
        Three = 3,

        [Display(Name = "Very Good")]
        Four = 4,

        [Display(Name = "Outstanding")]
        Five = 5
    }
}