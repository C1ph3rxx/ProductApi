using BusinessLogicLayer.Services;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        CategoryService _categoryService;

        public CategoryController (CategoryService categoryService)
        {
            _categoryService = categoryService;
        }




        public IActionResult GetById(int id)
        {
            Category? category = _categoryService.GetCategory(id);

            if(category == null)
            {
                return NotFound();

            }
            return Ok(category);
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            Category? createdCategory = _categoryService.CreateCategory(category, out string messgae);

            if (createdCategory == null )
            {
                return BadRequest(message);
            }

        }

        [HttpPost]
        public IActionResult UpdateCategory (Category category, out string message)
        {
            if (string.IsNullOrWhiteSpace( category.Description))
            {
                message = "Description is required";
                retutn
            }
        }
    }
}
