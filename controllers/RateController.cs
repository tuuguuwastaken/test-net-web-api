using Microsoft.AspNetCore.Mvc;
using LoanAPI.Models;
using LoanAPI.Services;

namespace LoanRatesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RatesController : ControllerBase
{
    //  init service and the controller
    private readonly IRateService _rateService;

    public RatesController(IRateService rateService)
    {
        _rateService = rateService;
    }

    // GET /api/rates
    // PARAMS : { string loanType, int term }
    [HttpGet]
    public ActionResult<Rate> Get([FromQuery] string loanType, [FromQuery] int term)
    {
        var rate = _rateService.GetRate(loanType, term);
        // case rate doesnt exist
        if (rate == null)
        {
            return NotFound(new { message = "Rate not found." });
        }

        return Ok(rate);
    }
}
