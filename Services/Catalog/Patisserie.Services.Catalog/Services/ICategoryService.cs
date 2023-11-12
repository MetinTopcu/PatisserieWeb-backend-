using Patisserie.Services.Catalog.Dtos;
using Patisserie.Services.Catalog.Models;
using Patisserie.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace Patisserie.Services.Catalog.Services
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();

        Task<Response<CategoryDto>> CreateAsync(CategoryDto category);

        Task<Response<CategoryDto>> GetByIdAsync(string id);

    }
}
