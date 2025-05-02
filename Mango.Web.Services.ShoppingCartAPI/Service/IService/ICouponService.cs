using Mango.Services.ShoppingCartAPI.Models.Dto;
namespace Mango.Web.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
