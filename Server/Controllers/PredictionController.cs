using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TSGUI.Server.Data;
using TSGUI.Server.Services;
using TSGUI.Shared;

namespace TSGUI.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PredictionController : Controller
    {
        private readonly IPredictionService _predictionService;
        public PredictionController(IPredictionService predictionService)
        {
            _predictionService = predictionService;
        }

        [HttpPost]
        public ActionResult<int?> GetPrediction([FromBody]Employee employee)
        {
           return _predictionService.Predict(employee);
        }

        [HttpGet]
        [Route("test")]
        public string GetTest(string test)
        {
            return test + "123";
        }
    }
}
