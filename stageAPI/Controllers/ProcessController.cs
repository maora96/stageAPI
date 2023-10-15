using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace stageAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        [HttpGet("{department}")]

        public async Task<ActionResult<List<Process>>> GetAllProcessesByDepartment(string department)
        {
            return Ok("ok");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Process>> GetProcess(int id)
        {
            return Ok(id);
        }
        
        [HttpPost]
        public async Task<ActionResult<Process>> AddProcess([FromBody]Process process)
        {
            return Ok(process);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Process>> UpdateProcess(int id, [FromBody] Process process)
        {
            return Ok(process);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Process>> DeleteProcess(int id)
        {
            return Ok(id);
        }
    }
}
