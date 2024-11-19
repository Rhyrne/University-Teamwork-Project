using Microsoft.AspNetCore.Mvc;
using MODMAPI.DTOs;
using MODMAPI.Services.Interfaces;

namespace MODMAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusinessController : ControllerBase
    {
        private readonly IBusinessService _businessService;

        public BusinessController(IBusinessService businessService)
        {
            _businessService = businessService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBusiness()
        {
            var businesses = await _businessService.GetAllBusinessesAsync();
            return Ok(businesses);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBusiness(BusinessDTO businessDTO)
        {
            var createdBusiness = await _businessService.CreateBusinessAsync(businessDTO);
            return CreatedAtAction(nameof(GetBusinessById), new { id = createdBusiness.BusinessId }, createdBusiness);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBusinessById(int id)
        {
            var business = _businessService.GetBusinessByIdAsync(id);

            if (business == null) return NotFound();

            return Ok(business);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusinessById(int id)
        {
            var deletedBusiness = await _businessService.DeleteBusinessAsync(id);

            if(!deletedBusiness) return NotFound();

            return Ok(deletedBusiness);
        }
    }
}
