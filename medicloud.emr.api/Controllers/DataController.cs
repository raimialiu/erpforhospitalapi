using System.Collections.Generic;
using medicloud.emr.api.Mocks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize]
    public class DataController : ControllerBase
    {
        private readonly MockDataRepository _mockRepo;
        public DataController(MockDataRepository mockRepo)
        {
            _mockRepo = mockRepo;
        }

        [HttpGet]
        public IActionResult GetData() => Ok(_mockRepo.FakeVitals());

        [Authorize(Roles = "Admin, Nurse")]
        [HttpGet("{id}")]
        public IActionResult GetSingleData(int id)
        {
            var data = _mockRepo.FakeVital(id);
            if (data is null) return NotFound("Vital Not Found");
            return Ok(data);
        }
        
    }
}