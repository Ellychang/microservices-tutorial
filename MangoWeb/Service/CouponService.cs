using MangoWeb.Models;
using MangoWeb.Utils;

namespace MangoWeb.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService) {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateCoupon(CouponDto couponDto)
        {
            return await _baseService.SendAsyc(new RequestDto()
            {
                ApiType = Utils.SD.ApiType.POST,
                Data = couponDto,
                Url = SD.CouponAPIBase + "api/coupon"
            });
        }

        public async Task<ResponseDto?> DeleteCoupon(int couponId)
        {
            return await _baseService.SendAsyc(new RequestDto()
            {
                ApiType = Utils.SD.ApiType.DELETE,
                Url = SD.CouponAPIBase + "api/coupon/" + couponId
            });
        }

        public async Task<ResponseDto?> GetAllCoupon()
        {
            return await _baseService.SendAsyc(new RequestDto()
            {
                ApiType = Utils.SD.ApiType.GET,
                Url = SD.CouponAPIBase + "api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCoupon(string couponCode)
        {
            return await _baseService.SendAsyc(new RequestDto()
            {
                ApiType = Utils.SD.ApiType.GET,
                Url = SD.CouponAPIBase + "api/coupon/" + couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponById(int couponId)
        {
            return await _baseService.SendAsyc(new RequestDto()
            {
                ApiType = Utils.SD.ApiType.GET,
                Url = SD.CouponAPIBase + "api/coupon/" + couponId
            });
        }

        public async Task<ResponseDto?> UpdateCoupon(CouponDto couponDto)
        {
            return await _baseService.SendAsyc(new RequestDto()
            {
                ApiType = Utils.SD.ApiType.PUT,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/coupon"
            });
        }
    }
}
