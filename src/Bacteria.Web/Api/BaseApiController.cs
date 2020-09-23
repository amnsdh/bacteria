using Microsoft.AspNetCore.Mvc;

namespace Bacteria.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
