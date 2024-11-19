using MODMAPI.DTOs;
using MODMAPI.Models;
using MODMAPI.Repositories.Interfaces;
using MODMAPI.Services.Interfaces;

namespace MODMAPI.Services.Implementations
{
    public class BusinessService : IBusinessService
    {
        private readonly IBusinessRepository _businessRepository;

        public BusinessService(IBusinessRepository businessRepository)
        {
           this._businessRepository = businessRepository;
        }

        public async Task<BusinessDTO> CreateBusinessAsync(BusinessDTO businessDTO)
        {
            var business = new Business
            {
                BusinessName = businessDTO.BusinessName,
                BusinessType = businessDTO.BusinessType,
                ReleaseTime = businessDTO.ReleaseTime,
                UserId = businessDTO.UserId,
            };

            var createdBusiness = await _businessRepository.CreateBusinessAsync(business);
            businessDTO.UserId = createdBusiness.UserId;
            return businessDTO;
        }

        public async Task<bool> DeleteBusinessAsync(int id)
        {
            return await _businessRepository.DeleteBusinessAsync(id);
        }

        public async Task<IEnumerable<BusinessDTO>> GetAllBusinessesAsync()
        {
            var business = await _businessRepository.GetAllBusinessAsync();
            if (business == null) return Enumerable.Empty<BusinessDTO>();

            return business.Select(b => new BusinessDTO
            {
                BusinessId = b.BusinessId,
                BusinessType = b.BusinessType,
                BusinessName = b.BusinessName,
                ReleaseTime = b.ReleaseTime,
                UserId = b.UserId
            });
        }

        public async Task<BusinessDTO> GetBusinessByIdAsync(int id)
        {
            var business = await _businessRepository.GetBusinessByIdAsync(id);
            if (business == null) return null;

            return new BusinessDTO
            {
                BusinessId = business.BusinessId,
                BusinessType = business.BusinessType,
                BusinessName = business.BusinessName,
                ReleaseTime = business.ReleaseTime,
                UserId = business.UserId
            };
        }
    }
}
