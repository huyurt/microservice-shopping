namespace MyShopping.Web.Utility
{
    public class SD
    {
        public static string AuthAPIBase { get; set; } 
        public static string CouponAPIBase { get; set; }

        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";

        public const string TokenCookie = "JWTToken";
    }
}
