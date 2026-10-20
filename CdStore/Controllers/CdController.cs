using CdStore.Data;
using CdStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;
namespace CdStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CdsController : ControllerBase
    {
        private readonly CdDbContext _context;
        public CdsController(CdDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        
        public IActionResult GetAllCds()
        {
            var CDs = _context.CDs.ToList();

            return Ok(CDs);
        }
    }
}
