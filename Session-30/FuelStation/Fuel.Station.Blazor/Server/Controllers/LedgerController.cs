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
        public class MonthlyLedgerController : ControllerBase
        {
            // Properties
            private readonly IEntityRepo<Transaction> _transactionRepo;
            private readonly IEntityRepo<Employee> _employeeRepo;
            private readonly IEntityRepo<Item> _itemRepo;



            // Constructors
            public MonthlyLedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Item> itemRepo)
            {
                _transactionRepo = transactionRepo;
                _employeeRepo = employeeRepo;
                _itemRepo = itemRepo;
            }

            // GET: /<EmployeeController>
            [HttpGet]
            public async Task<IEnumerable<Ledger>> Get()
            {
                var employees = await Task.Run(() => { return _employeeRepo.GetAll(); });
                var transactions = await Task.Run(() => { return _transactionRepo.GetAll(); });

                var monthlyLedgerList = new LedgerSolution().GetAllMonthlyLedgers(employees, transactions);

                return monthlyLedgerList;
            }
        }

    }
}
