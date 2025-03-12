using AutoMapper;
using BusinessLogicLayer.IServices;
using BusinessLogicLayer.Services;
using Domain.DTO;
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
        ICategoryService _categoryService;
        IMapper _mapper;
        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCategory()
        {

            return Ok(_mapper.Map<IList<GetCategoryDto>>(_categoryService.GetAllCategory()));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            Category? category = _categoryService.GetCategory(id, out string message);

            if(category is null)
            {
                return NotFound(message);
            }
            return Ok(_mapper.Map<GetCategoryDto>(category));
        }

        [HttpPost("create")]
        public IActionResult CreateCategory( [FromBody] CreateRequestCategoryDto category)
        {
            Category? createdCategory = _categoryService.CreateCategory(category, out string message);

            if (createdCategory is null )
            {
                return BadRequest(message);
            }

            //return Ok(createdCategory);
            return Ok(_mapper.Map<CreateRequestCategoryDto>(category));

        }

        [HttpPost("update")]
        public IActionResult UpdateCategory ([FromBody] Category category )
        {
            Category? updatedCategory = _categoryService.UpdateCategory(category, out string message);
         
            if(updatedCategory is null )
            {
                return BadRequest(message);
            }
            return Ok(updatedCategory);
        }
    }
}
