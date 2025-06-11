using LoanAPI.Models;

namespace LoanAPI.Services;

public interface IRateService
{
    // find the matching data from the mock DB in RateService
    Rate? GetRate(string loanType, int term);
}