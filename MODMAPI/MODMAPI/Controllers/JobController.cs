using Microsoft.AspNetCore.Mvc;
using MODMAPI.DTOs;
using MODMAPI.Services.Interfaces;

namespace MODMAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobs = await _jobService.GetAllJobsAsync();
            return Ok(jobs);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJob(JobDTO jobDTO)
        {
            var createdJob = await _jobService.CreateJobAsync(jobDTO);
            return CreatedAtAction(nameof(GetJobById), new {id = createdJob.JobId}, createdJob);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetJobById(int id)
        {
            var job = await _jobService.GetJobByIdAsync(id);

            if(job == null) return NotFound();

            return Ok(job);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobById(int id)
        {
            var deletedJob = await _jobService.DeleteJobAsync(id);

            if (!deletedJob) return NotFound();

            return Ok(deletedJob);
        }
    }
}
