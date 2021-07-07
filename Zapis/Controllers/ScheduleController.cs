using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Zapis.Services.ScheduleService;

namespace Zapis.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class ScheduleController : ControllerBase
    {       
        // [HttpGet]
        // public List<ScheduleItem> GetSchedule(Guid userId, Guid tenantId, DateTime from, DateTime to)
        // {
        //     throw new NotImplementedException();
        // }

        // [HttpPost]
        // public ScheduleItem Schedule(Guid userId, Guid tenantId, Guid lineId, DateTime dateTime, Guid operationId, OperationSettings operationSettings, string comment)
        // {
        //     var message = new Message() { DateTime = DateTime.UtcNow, Text = comment };

        //     throw new NotImplementedException();
        // }
    }
}