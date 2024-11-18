using Microsoft.AspNetCore.Mvc;
using webapicourse.Models;

namespace webapicourse.Controllers
{    

    //controller tanımı yapacaksam böyle bir template var 
    [ApiController]
    [Route("home")] 
    //client application get post put delete gibi birçok istek gönderebilir ben burda
    //geti kullandım 
    public class HomeController : ControllerBase 
    {
        [HttpGet("Message")]
        public string GetMessage()
        {
            return "hello asp.net core web api"; 
        }
        [HttpGet("Message2")]
        public IActionResult GetMessage2()
        {
           var result  = new ResponseModel()
            {
                HttpStatus = 200,
                Message = "asp.net course web api"

             };
            return Ok(result); 

        }
    }
}
