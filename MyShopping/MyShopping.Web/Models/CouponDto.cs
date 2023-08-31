namespace MyShopping.Web.Models
{
    public class CouponDto
    {
        public long Id { get; set; }

        public string Code { get; set; }

        public decimal DiscountAmount { get; set; }

        public int MinAmount { get; set; }
    }
}
