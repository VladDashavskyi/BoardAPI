using BoardAPI.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BoardAPI.Controllers
{
    [ApiController]
    [Route("dictionary")]
    public class DictionaryController : Controller
    {
        private readonly AnnouncementRepository _repository;

        public DictionaryController(AnnouncementRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("categories")]
        public async Task<IActionResult> GetAllCategoriesAsync() =>
            Ok(await _repository.GetAllCategoriesAsync());

        [HttpGet("categories/{id}")]
        public async Task<IActionResult> GetCategoryByIdAsync(int id)
        {
            var ad = await _repository.GetCategoryByIdAsync(id);
            return ad == null ? NotFound() : Ok(ad);
        }

        [HttpGet("subcategories")]
        public async Task<IActionResult> GetAllSubCategoriesAsync() =>
            Ok(await _repository.GetAllSubCategoriesAsync());

        [HttpGet("subcategories/{id}")]
        public async Task<IActionResult> GetSubCategoryByIdAsync(int id)
        {
            var ad = await _repository.GetSubCategoryByIdAsync(id);
            return ad == null ? NotFound() : Ok(ad);
        }
    }
}
