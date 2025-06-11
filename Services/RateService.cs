using LoanAPI.Models;

namespace LoanAPI.Services;

public class RateService : IRateService
{
    // fake DB simulated when you request from with the parameters it will search from here.
    private readonly List<Rate> _mockRates = new()
    {
        new Rate { loanType = "owner-occupied", term = 30, interestRate = 5.25f },
        new Rate { loanType = "owner-occupied", term = 15, interestRate = 4.75f },
        new Rate { loanType = "investment", term = 30, interestRate = 6.15f },
    };

    public Rate? GetRate(string loanType, int term)
    {
        // checking is there is a matching loan fron the read only List _mockrates with Equals.
        return _mockRates.FirstOrDefault(r =>
            r.loanType.Equals(loanType, StringComparison.OrdinalIgnoreCase) &&
            r.term == term);
    }
}