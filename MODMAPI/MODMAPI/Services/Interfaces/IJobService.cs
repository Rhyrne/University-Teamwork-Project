using MODMAPI.DTOs;

namespace MODMAPI.Services.Interfaces
{
    public interface IJobService
    {
        Task<IEnumerable<JobDTO>> GetAllJobsAsync();
        Task<JobDTO> CreateJobAsync(JobDTO job);
        Task<bool> DeleteJobAsync(int id);
        Task<JobDTO> GetJobByIdAsync(int id);
    }
}
