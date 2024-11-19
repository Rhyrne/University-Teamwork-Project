using MODMAPI.DTOs;
using MODMAPI.Models;
using MODMAPI.Repositories.Interfaces;
using MODMAPI.Services.Interfaces;

namespace MODMAPI.Services.Implementations
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            this._jobRepository = jobRepository;
        }

        public async Task<JobDTO> CreateJobAsync(JobDTO jobDTO)
        {
            var job = new Job
            {
                JobDescription = jobDTO.JobDescription,
                JobTitle = jobDTO.JobTitle,
                ReleaseTime = jobDTO.ReleaseTime,
                UserId = jobDTO.UserId
            };

            var createdJob = await _jobRepository.CreateJobAsync(job);
            jobDTO.JobId = createdJob.JobId;
            return jobDTO;
        }

        public async Task<bool> DeleteJobAsync(int id)
        {
            return await _jobRepository.DeleteJobAsync(id);
        }

        public async Task<IEnumerable<JobDTO>> GetAllJobsAsync()
        {
            var job = await _jobRepository.GetAllJobsAsync();
            if (job == null) return Enumerable.Empty<JobDTO>();

            return job.Select(j => new JobDTO {
                JobId = j.JobId,
                JobDescription = j.JobDescription, 
                JobTitle = j.JobTitle, 
                ReleaseTime = j.ReleaseTime, 
                UserId = j.UserId 
            });
        }

        public async Task<JobDTO> GetJobByIdAsync(int id)
        {
            var job = await _jobRepository.GetJobsByIdAsync(id);
            if (job == null) return null;

            return new JobDTO { 
                JobId = job.JobId,  
                JobDescription = job.JobDescription, 
                JobTitle = job.JobTitle, 
                ReleaseTime = job.ReleaseTime, 
                UserId = job.UserId 
            };
        }
    }
}
