using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Zapis.Services.TenantService;


namespace Zapis.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("[controller]")]
    public class TenantController : ControllerBase
    {
        private TenantService _tenantService;


        public TenantController(TenantService tenantService)
        {
            _tenantService = tenantService;
        }


        [HttpGet]
        [Route("tenants")]
        public async Task<List<TenantShortInfo>> GetAll()
        {
            var tennants = await _tenantService.GetAllTennants();
            return tennants;
        }

        [HttpGet]
        [Route("tenant")]
        public async Task<Tenant> Get(Guid id)
        {
            var tennant = await _tenantService.GetTennant(id);
            return tennant;
        }
    }
}