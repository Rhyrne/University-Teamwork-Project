using MODMAPI.DTOs;

namespace MODMAPI.Services.Interfaces
{
    public interface IBusinessService
    {
        Task<IEnumerable<BusinessDTO>> GetAllBusinessesAsync();
        Task<BusinessDTO> CreateBusinessAsync(BusinessDTO businessDTO);
        Task<bool> DeleteBusinessAsync(int id);
        Task<BusinessDTO> GetBusinessByIdAsync(int id);
    }
}
