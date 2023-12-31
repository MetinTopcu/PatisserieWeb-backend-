﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patisserie.Services.Basket.Dtos;
using Patisserie.Services.Basket.Services;
using Patisserie.Shared.ControllerBases;
using Patisserie.Shared.Services;
using System.Threading.Tasks;

namespace Patisserie.Services.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : CustomBaseController
    {
        private readonly IBasketService _basketService;
        private readonly ISharedIdentityService _sharedIdentityService;

        public BasketsController(IBasketService basketService, ISharedIdentityService sharedIdentityService)
        {
            _basketService = basketService;
            _sharedIdentityService = sharedIdentityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBasket()
        {

            //var claims = User.Claims;

            var response = await _basketService.GetBasket(_sharedIdentityService.GetUserId);

            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrUpdateBasket(BasketDto basketdto)
        {
            var response = await _basketService.SaveOrUpdate(basketdto);

            return CreateActionResultInstance(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            var response = await _basketService.Delete(_sharedIdentityService.GetUserId);

            return CreateActionResultInstance(response);
        }
    }
}
