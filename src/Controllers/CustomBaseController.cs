using Microsoft.AspNetCore.Mvc;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public abstract class CustomBaseController : ControllerBase // Create a custom base controller to apply inherting to multiple controllers
    {

    }
}