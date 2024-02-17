namespace coupon.Models.Dto
{
    public class CouponDto
    {
        // From the database
        public int CoupionId { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
