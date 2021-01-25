using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibraryControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestoController : ControllerBase
    {
        public TestoController()
        {

        }

        [Route("viron")]
        [HttpGet]
        public string Testo()
        {
            string xd = "xd";
            return xd;
        }

    }
}
