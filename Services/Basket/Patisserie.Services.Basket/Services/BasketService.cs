using Patisserie.Services.Basket.Dtos;
using Patisserie.Shared.Dtos;
using System.Threading.Tasks;

namespace Patisserie.Services.Basket.Services
{
    public class BasketService : IBasketService
    {
        public Task<Response<bool>> Delete(string userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<BasketDto>> GetBasket(string userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<bool>> SaveOrUpdate(BasketDto basket)
        {
            throw new System.NotImplementedException();
        }
    }
}
