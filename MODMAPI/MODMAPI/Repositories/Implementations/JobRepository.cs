using Microsoft.EntityFrameworkCore;
using MODMAPI.Data;
using MODMAPI.Models;
using MODMAPI.Repositories.Interfaces;

namespace MODMAPI.Repositories.Implementations
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext _context;

        public JobRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Job> CreateJobAsync(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task<bool> DeleteJobAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            if (job == null) return false;

            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Job>> GetAllJobsAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job> GetJobsByIdAsync(int id)
        {
            return await _context.Jobs.FirstOrDefaultAsync(j => j.JobId == id);
        }
    }
}
