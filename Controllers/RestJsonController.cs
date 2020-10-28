using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApiNetCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RestJsonController : ControllerBase
    {
        public string Get()
        {
            string json = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader("file.json"))
            {
                json = r.ReadToEnd();
            }
            return json;
        }
    }
}
