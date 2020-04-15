using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Template;
using Entities.BusinessEntities;
using BusinessLayer.Services.ServiceContracts;
using BusinessLayer.Services;

namespace WebApi.Controllers.Settings
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class CaregiverController : ControllerTemplate<Caregiver, CaregiverService>
    {
        
    }
}
 