# LoanAPI

A minimal .NET Core Web API that returns mock loan rate data via a simple GET endpoint.

## Features

- `GET /api/rates?loanType={loanType}&term={term}`
- Returns mock/static loan rate data
- Swagger UI for API testing ``http://localhost:5025``

## 🔧 How to Run

```bash
dotnet run
```

## To test

example use ( either open in browser or use curl )

```
http://localhost:5025/api/rates?loanType=owner-occupied&term=30
```




this Readme was made from a template
