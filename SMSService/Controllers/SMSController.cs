using Microsoft.AspNetCore.Mvc;
using SMSService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMSService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSController : ControllerBase
    {
        [Route("api/[controller]")]
        [ApiController]
        public class SMSControllers : ControllerBase
        {
            private const string LOGFILENAME = "c:\\temp\\TextMessages.txt";

            // POST api/<SMSController>
            [HttpPost]
            public void Post(CreateSMS msg)
            {
                if (ModelState.IsValid)
                {
                    log("Sent: " + msg);
                    //return (IHttpActionResult)Ok();
                }
                else
                {
                    //return (IHttpActionResult)BadRequest();
                }
            }

            private void log(string logText)
            {
                try
                {
                    StreamWriter logWriter = new StreamWriter(LOGFILENAME, true);
                    logWriter.Write(logText);
                    logWriter.WriteLine(" " + DateTime.Now);
                    logWriter.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
