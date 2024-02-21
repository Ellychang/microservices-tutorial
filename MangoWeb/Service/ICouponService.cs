using MangoWeb.Models;

namespace MangoWeb.Service
{
    public interface ICouponService
    {
        Task<ResponseDto?> CreateCoupon(CouponDto couponDto);
        Task<ResponseDto?> GetCoupon(string couponCode);
        Task<ResponseDto?> GetAllCoupon();
        Task<ResponseDto?> UpdateCoupon(CouponDto couponDto);
        Task<ResponseDto?> GetCouponById(int couponId);
        Task<ResponseDto?> DeleteCoupon(int couponId);
    }
}
