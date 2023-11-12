﻿using Patisserie.Services.Catalog.Dtos;
using Patisserie.Services.Catalog.Models;
using Patisserie.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patisserie.Services.Catalog.Services
{
    internal interface IProductService
    {
        Task<Response<List<ProductDto>>> GetAllAsync();
        Task<Response<ProductDto>> GetByIdAsync(string id);

        Task<Response<List<ProductDto>>> GetAllByUserIdAsync(string userId);

        Task<Response<ProductDto>> CreateAsync(ProductCreateDto productCreateDto);

        Task<Response<NoContent>> UpdateAsync(ProductUpdateDto productUpdateDto);

        Task<Response<NoContent>> DeleteAsync(string id);
    }
}
