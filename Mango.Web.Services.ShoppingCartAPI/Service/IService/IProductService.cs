using Mango.Web.Services.ShoppingCartAPI.Models.Dto;

namespace Mango.Web.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
