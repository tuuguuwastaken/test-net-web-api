namespace LoanAPI.Models;


// Defining the model
// loanType : string
// term : int
// interestRate : float
public class Rate
{
    public string loanType { get; set; } = string.Empty;
    public int term { get; set; }
    public float interestRate { get; set; }
}