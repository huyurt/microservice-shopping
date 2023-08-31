using MyShopping.Web.Models;
using MyShopping.Web.Service.Contract;
using MyShopping.Web.Utility;

namespace MyShopping.Web.Service
{
	public class CouponService : ICouponService
	{
		private readonly IBaseService _baseService;

		public CouponService(IBaseService baseService)
		{
			_baseService = baseService;
		}

		public async Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				HttpMethod = HttpMethod.Post,
				Data = couponDto,
				Url = SD.CouponAPIBase + "/api/coupon",
			});
		}

		public async Task<ResponseDto?> DeleteCouponAsync(long id)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				HttpMethod = HttpMethod.Delete,
				Url = SD.CouponAPIBase + "/api/coupon/" + id,
			});
		}

		public async Task<ResponseDto?> GetAllCouponsAsync()
		{
			return await _baseService.SendAsync(new RequestDto
			{
				HttpMethod = HttpMethod.Get,
				Url = SD.CouponAPIBase + "/api/coupon",
			});
		}

		public async Task<ResponseDto?> GetCouponAsync(string code)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				HttpMethod = HttpMethod.Get,
				Url = SD.CouponAPIBase + "/api/coupon/GetByCode" + code,
			});
		}

		public async Task<ResponseDto?> GetCouponByIdAsync(long id)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				HttpMethod = HttpMethod.Get,
				Url = SD.CouponAPIBase + "/api/coupon/" + id,
			});
		}

		public async Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				HttpMethod = HttpMethod.Put,
				Data = couponDto,
				Url = SD.CouponAPIBase + "/api/coupon",
			});
		}
	}
}
