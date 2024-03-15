
using APIFun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlRepository _bowlerRepository;
        public BowlerController(IBowlRepository temp) {
            _bowlerRepository = temp;
        }
        [HttpGet]
        public IEnumerable<BowlingFin> Get()
        {
            var bowlerData = _bowlerRepository.GetAllBowlers();

            return bowlerData;
        }
    }
}
