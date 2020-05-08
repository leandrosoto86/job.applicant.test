using System;
using System.Threading.Tasks;
using BestHB.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BestHB.Controllers
{
    [Route("api/instrument")]
    public class InstrumentController : Controller
    {
        private readonly IRepository _instrumentInfoRepository;

        public InstrumentController(IRepository instrumentInfoRepository)
        {
            _instrumentInfoRepository = instrumentInfoRepository;
        }

        [HttpGet]
        [Route("{symbol}")]
        public async Task<IActionResult> Get([FromRoute] string symbol)
        {
            try
            {
                return Ok(await _instrumentInfoRepository.Get(symbol));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}