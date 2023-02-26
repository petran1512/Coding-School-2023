using Fuel.Solution.EF.Repositories;
using Fuel.Station.Blazor.Shared;
using Fuel.Station.Model;
using Microsoft.AspNetCore.Mvc;

namespace Fuel.Station.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LedgerController : ControllerBase
    {
            // Properties
            private readonly IEntityRepo<Transaction> _transactionRepo;
            private readonly IEntityRepo<Employee> _employeeRepo;
            private readonly IEntityRepo<Item> _itemRepo;
            private readonly decimal _rent = 5000;
            private readonly DateTime _openingDate = new DateTime(2022, 1, 1);


            // Constructors
            public LedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Item> itemRepo)
            {
                _transactionRepo = transactionRepo;
                _employeeRepo = employeeRepo;
                _itemRepo = itemRepo;
            }

            // GET: api/<TransactionController>
            [HttpGet]
            public async Task<IEnumerable<LedgerDto>> Get()
            {
                var result = await Task.Run(() => { return _transactionRepo.GetAll(); });
                List<LedgerDto?> monthlyLedgers = new List<LedgerDto?>();
                if (result == null)
                {
                    return null;
                }

                var transactionList = _transactionRepo.GetAll();

                var employees = _employeeRepo.GetAll();

                decimal monthlyPayments = 0;

                foreach (var employee in employees)
                {
                    monthlyPayments += employee.SallaryPerMonth;
                }

                DateTime dateTimeNow = DateTime.Now;
                DateTime currentLedger = _openingDate;

                int totalMonths = ((dateTimeNow.Year - _openingDate.Year) * 12) + dateTimeNow.Month - _openingDate.Month;

                for (var i = 0; i < totalMonths + 1; i++)
                {
                    var ml = new LedgerDto(currentLedger);
                    ml.Expenses += monthlyPayments;
                    ml.AddRent(_rent);
                    monthlyLedgers.Add(ml);
                    currentLedger = currentLedger.AddMonths(1);
                }

                foreach (var transaction in transactionList)
                {
                    foreach (var monthlyLedger in monthlyLedgers)
                    {
                        if ((transaction.Date.Month == monthlyLedger.Month) && (transaction.Date.Year == monthlyLedger.Year))
                        {
                            monthlyLedger.Transactions.Add(transaction);
                        }
                    }
                }

                foreach (var monthlyLedger in monthlyLedgers)
                {
                    foreach (var transaction in monthlyLedger.Transactions)
                    {
                        foreach (var transactionLine in transaction.TransactionLines)
                        {
                            monthlyLedger.Expenses += _itemRepo.GetById(transactionLine.ItemId).Cost * transactionLine.Quantity;
                            monthlyLedger.Income += transactionLine.TotalValue;
                        }

                    }
                    monthlyLedger.Total = monthlyLedger.Income - monthlyLedger.Expenses;
                monthlyLedger.Transactions = new List<Transaction?>();
                }
                return monthlyLedgers;
            }
        }
    }
