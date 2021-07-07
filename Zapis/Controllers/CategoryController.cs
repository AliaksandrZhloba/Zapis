using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Zapis.Services.CategoryService;

namespace Zapis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;

        private readonly CategoryService _categoryService;


        public CategoryController(ILogger<CategoryController> logger, CategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet]
        [Route("categories")]
        public async Task<List<Category>> GetAll()
        {
            var categories = await _categoryService.GetAllCategories();
            return categories;
        }

        [HttpGet]
        [Route("search")]
        public async Task<List<Category>> Search([FromQuery]string text)
        {
            var categories = await _categoryService.SearchCategories(text);
            return categories;
        }
    }
}