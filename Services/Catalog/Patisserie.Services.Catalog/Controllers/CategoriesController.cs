﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patisserie.Services.Catalog.Dtos;
using Patisserie.Services.Catalog.Services;
using Patisserie.Shared.ControllerBases;
using System.Threading.Tasks;

namespace Patisserie.Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();

            return CreateActionResultInstance(categories);  
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id) 
        {
            var categories = await _categoryService.GetByIdAsync(id);

            return CreateActionResultInstance(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
           var response =  await _categoryService.CreateAsync(categoryDto);

            return CreateActionResultInstance(response);
        }
    }
}
