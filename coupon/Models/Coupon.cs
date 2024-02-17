using System.ComponentModel.DataAnnotations;

namespace coupon.Models
{
    public class Coupon
    {
        // Model for the API

        [Key]
        public int CoupionId { get; set; }

        [Required]
        public string CouponCode { get; set; }

        [Required]
        public double DiscountAmount { get; set; }

        [Required]
        public int MinAmount { get; set; }
    }
}
