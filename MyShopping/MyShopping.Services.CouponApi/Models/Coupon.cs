using System.ComponentModel.DataAnnotations;

namespace MyShopping.Services.CouponApi.Models
{
    public class Coupon
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public decimal DiscountAmount { get; set; }

        public int MinAmount { get; set; }
    }
}
