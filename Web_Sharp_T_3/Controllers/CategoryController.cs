using Microsoft.AspNetCore.Mvc;
using Web_Sharp_T_3.Models;
using Web_Sharp_T_3.Interfaces;

namespace Web_Sharp_T_3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;
        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet("GetСategories")]
        public ActionResult GetСategories()
        {
            var res = _categoryManager.GetCategories();
            return Ok(res);
        }
        [HttpPut("AddCategory")]
        public ActionResult AddCategory([FromBody] Category categoryDTO)
        {
            var res = _categoryManager.AddCategory(categoryDTO);
            return Ok($"Добавлена категория {res}!");
        }
        [HttpDelete("DeleteCategory")]
        public ActionResult DeleteCategory(int id)
        {
            var res = _categoryManager.DeleteCategory(id);
            if (res == false)
                return StatusCode(500);
            return Ok($"Категория {id} успешно удалена");
        }
    }
}
