

namespace Sales.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
       // [Inedx("EmailIndex", isUnique = true)]
        public string Description { get; set; }


        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Display(Name ="Image")]
        public string ImagePath { get; set; }

       // [DisplayFormat(DataFormatString ="{0:C2}")]//, ApplyFormatInEditMode= true)]
     //   public Decimal Price { get; set; }
        public int Price { get; set; }

        [Display(Name ="Is Available")]
        public bool IsAvailable { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Publish On")]
        public DateTime PublishOn { get; set; }

        public override string ToString()
        {
            return this.Description;
        }

    }
}
