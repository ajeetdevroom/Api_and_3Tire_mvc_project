using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RikeshServices_API.Model;
using RikeshServices_API.BAL;
using Microsoft.AspNetCore.Cors;


namespace RikeshServices_API.Controllers
{
    [EnableCors("AllowAllHeaders")]
    [Route("api/[controller]")]
    [ApiController]
    public class SudentDetailsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet("[action]")]
        public ActionResult<IEnumerable<string>> test()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost("[action]")]
        public ActionResult SaveStudentDetails([FromBody] Student std)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    RikeshServices_API.BAL.BusinessLogic bl = new RikeshServices_API.BAL.BusinessLogic();
                    int res = bl.saveStudentDetails(std);
                }
            }
            catch(Exception ex)
            {
                return this.Ok(
                    "Faield"
                    );
            }
            return Unauthorized();
        }
    }
}


