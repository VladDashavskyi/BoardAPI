using BoardAPI.DAL.Repositories;
using BoardAPI.Common.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BoardAPI.Controllers
{
    [ApiController]
    [Route("announcement")]
    public class AnnouncementController : ControllerBase
    {
        private readonly AnnouncementRepository _repository;

        public AnnouncementController(AnnouncementRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync() =>
            Ok(await _repository.GetAllAnnouncementsAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var announcement = await _repository.GetAnnouncementByIdAsync(id);
            return announcement == null ? NotFound() : Ok(announcement);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] AnnouncementDto announcement)
        {
            var rows = await _repository.CreateAnnouncementAsync(announcement);
            return rows > 0 ? Ok() : StatusCode(400);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] AnnouncementDto announcement)
        {
            var rows = await _repository.UpdateAnnouncementAsync(announcement);
            return rows > 0 ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var rows = await _repository.DeleteAnnouncementAsync(id);
            return rows > 0 ? NoContent() : NotFound();
        }
    }
}
