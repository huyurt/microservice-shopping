using MyShopping.Web.Models;

namespace MyShopping.Web.Service.Contract
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string code);

        Task<ResponseDto?> GetAllCouponsAsync();

        Task<ResponseDto?> GetCouponByIdAsync(long id);

        Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto);

        Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto);

        Task<ResponseDto?> DeleteCouponAsync(long id);
    }
}
