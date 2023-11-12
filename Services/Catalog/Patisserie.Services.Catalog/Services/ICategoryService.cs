using Patisserie.Services.Catalog.Dtos;
using Patisserie.Services.Catalog.Models;
using Patisserie.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace Patisserie.Services.Catalog.Services
{
    internal interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();

        Task<Response<CategoryDto>> CreateAsync(Category category);

        Task<Response<CategoryDto>> GetByIdAsync(string id);

    }
}
