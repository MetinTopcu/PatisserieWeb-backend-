using Patisserie.Services.Basket.Dtos;
using Patisserie.Shared.Dtos;
using System.Threading.Tasks;

namespace Patisserie.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userId);

        Task<Response<bool>> SaveOrUpdate(BasketDto basketdto);

        Task<Response<bool>> Delete(string userId);
    }
}
