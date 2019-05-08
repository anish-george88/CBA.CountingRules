using CBA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountingController : ControllerBase
    {
        private CountingService CountingService;

        public CountingController(CountingService service)
        {
            CountingService = service;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        [Route("{inputText}")]
        [HttpGet("inputText")]
        public async Task<bool> Counting(string inputText)
        {
            return await CountingService.RunCountingRules(inputText);
        }
    }
}