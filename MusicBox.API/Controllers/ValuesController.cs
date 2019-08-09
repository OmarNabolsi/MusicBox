
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MusicBox.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"Value 1", "Value 2"};
        }
    }
}