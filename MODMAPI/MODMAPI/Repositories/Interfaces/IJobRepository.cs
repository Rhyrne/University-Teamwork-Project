using MODMAPI.Models;

namespace MODMAPI.Repositories.Interfaces
{
    public interface IJobRepository
    {
        Task<IEnumerable<Job>> GetAllJobsAsync();
        Task<Job> CreateJobAsync(Job job);
        Task<bool> DeleteJobAsync(int id);
        Task<Job> GetJobsByIdAsync(int id);
    }
}
