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
        public async Task<ResponseDto?> DeleteCoupon(string couponCode)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetAllCoupon()
        {
            return await _baseService.SendAsyc(new RequestDto()
            {
                ApiType = Utils.SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCoupon(string couponCode)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetCouponById(int couponId)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> UpdateCoupon(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }
    }
}
