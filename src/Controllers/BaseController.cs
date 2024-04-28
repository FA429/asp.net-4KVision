using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{

       [ApiController]
    [Route("/api/v1/[controller]s")]
    public abstract class BaseController : ControllerBase
    {

       
    }
}