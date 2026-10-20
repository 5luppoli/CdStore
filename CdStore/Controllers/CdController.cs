using CdStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;
namespace CdStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CdController : ControllerBase
    {

        [HttpGet]
        public async Task<CDs> Get()
        {
            {

                return Ok(await CdController.GetAll().ToArrayAsync(HttpContext.RequestAborted));
            }
        }
    }
}
