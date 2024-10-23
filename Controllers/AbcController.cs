using Field_Bool.DTOs;
using Field_Bool.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Field_Bool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbcController : ControllerBase
    {
        private readonly Service_Done _service;
        public AbcController(Service_Done service)
        {
            _service = service;
        }
        [HttpGet("zero")]
        public ActionResult<Response> GetZero()
        {
            var a=_service.GetZero();
            return Ok(a);
        }
    }
}