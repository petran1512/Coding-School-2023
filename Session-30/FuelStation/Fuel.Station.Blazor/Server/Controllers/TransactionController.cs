using Fuel.Solution.EF.Repositories;
using Fuel.Station.Blazor.Shared;
using Fuel.Station.Model;
using FuelStation.Model.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fuel.Station.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        // Properties
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IValidator _validator;
        private string _errorMessage;

        // Constructors
        public TransactionController(IEntityRepo<Transaction> transactionRepo, IValidator validator, IEntityRepo<Item> itemRepo)
        {
            _transactionRepo = transactionRepo;
            _validator = validator;
            _errorMessage = string.Empty;
            _itemRepo = itemRepo;
        }

        // GET: /<CustomersController>
        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get()
        {
            var result = await Task.Run(() => { return _transactionRepo.GetAll(); });
            var selectTransactionList = result.Select(transaction => new TransactionListDto
            {
                Id = transaction.Id,
                Date = transaction.Date,
                PaymentMethod = transaction.PaymentMethod,
                TotalValue = transaction.TotalValue,
                EmployeeId = transaction.EmployeeId,
                CustomerId = transaction.CustomerId,
            });
            return selectTransactionList;
        }

        // GET: api/<TransactionController>
        [HttpGet("{id}")]
        public async Task<TransactionEditDto?> GetById(int id)
        {
            var tran = await Task.Run(() => { return _transactionRepo.GetById(id); });
            if (tran == null)
            {
                return null;
            }

            var transaction = new TransactionEditDto
            {
                Id = id,
                Date = tran.Date,
                TotalValue = tran.TotalValue,
                PaymentMethod = tran.PaymentMethod,
                CustomerId = tran.CustomerId,
                EmployeeId = tran.EmployeeId,
                TransactionLines = tran.TransactionLines.Select(transactionLine => new TransactionLineEditDto
                {
                    Id = transactionLine.Id,
                    TransactionId = transactionLine.TransactionId,
                    ItemId = transactionLine.ItemId,
                    Quantity = transactionLine.Quantity,
                    ItemPrice = transactionLine.ItemPrice,
                    NetValue = transactionLine.NetValue,
                    DiscountPercent = transactionLine.DiscountPercent,
                    DiscountValue = transactionLine.DiscountValue,
                    TotalValue = transactionLine.TotalValue,
                }).ToList()
            };

            return transaction;
        }

        // GET: api/<TransactionController>
        [Route("/transactionlist/details/{id}")]
        [HttpGet]
        public async Task<TransactionDetailsDto?> GetDetailsById(int id)
        {
            var tran = await Task.Run(() => { return _transactionRepo.GetById(id); });
            if (tran is null)
            {
                return null;
            }
            else
            {
                TransactionDetailsDto transaction = new TransactionDetailsDto
                {
                    Id = id,
                    Date = tran.Date,
                    EmployeeId = tran.EmployeeId,
                    CustomerId = tran.CustomerId,
                    PaymentMethod = tran.PaymentMethod,
                    TotalValue = tran.TotalValue,
                    Customer = new CustomerListDto
                    {
                        Id = tran.CustomerId,
                        Name = tran.Customer.Name,
                        Surname = tran.Customer.Surname,
                        CardNumber = tran.Customer.CardNumber,
                    },
                    Employee = new EmployeeListDto
                    {
                        Id = tran.EmployeeId,
                        Name = tran.Employee.Name,
                        Surname = tran.Employee.Surname,
                        HireDateStart = tran.Employee.HireDateStart,
                        HireDateEnd = tran.Employee.HireDateEnd,
                        SallaryPerMonth = tran.Employee.SallaryPerMonth,
                        employeeType = tran.Employee.employeeType
                    },
                    TransactionLines = tran.TransactionLines.Select(transactionLine => new TransactionLineDetailsDto
                    {
                        Id = transactionLine.Id,
                        TransactionId = transactionLine.TransactionId,
                        ItemId = transactionLine.ItemId,
                        Quantity = transactionLine.Quantity,
                        ItemPrice = transactionLine.ItemPrice,
                        NetValue = transactionLine.NetValue,
                        DiscountPercent = transactionLine.DiscountPercent,
                        DiscountValue = transactionLine.DiscountValue,
                        TotalValue = transactionLine.TotalValue,
                    }).ToList()
                };
                foreach (var transactionLine in transaction.TransactionLines)
                {
                    var item = _itemRepo.GetById(transactionLine.ItemId);
                    transactionLine.Item = new ItemListDto
                    {
                        Id = item.Id,
                        Code = item.Code,
                        Description = item.Description,
                        itemType = item.itemType,
                        Price = item.Price,
                        Cost = item.Cost,
                    };
                }
                return transaction;
            }
        }
        // POST api/<TransactionController>
        [HttpPost]
        public async Task Post(TransactionEditDto transaction)
        {
            var newTransaction = new Transaction(transaction.Date, transaction.PaymentMethod,
                transaction.TotalValue, transaction.EmployeeId, transaction.CustomerId)
            {
                Date = transaction.Date,
                EmployeeId = transaction.EmployeeId,
                CustomerId = transaction.CustomerId,
                PaymentMethod = transaction.PaymentMethod,
                TotalValue = transaction.TotalValue,
                TransactionLines = transaction.TransactionLines.Select(transactionLine => new TransactionLine(transactionLine.Quantity, transactionLine.ItemPrice, transactionLine.NetValue,
                transactionLine.DiscountPercent, transactionLine.DiscountValue, transactionLine.TotalValue)
                {
                    Id = transactionLine.Id,
                    TransactionId = transactionLine.TransactionId,
                    ItemId = transactionLine.ItemId,
                    //Quantity = transactionLine.Quantity,
                    //ItemPrice = transactionLine.ItemPrice,
                    //NetValue = transactionLine.NetValue,
                    //DiscountPercent = transactionLine.DiscountPercent,
                    //DiscountValue = transactionLine.DiscountValue,
                    //TotalValue = transactionLine.TotalValue,
                }).ToList()
            };
            await Task.Run(() => { _transactionRepo.Add(newTransaction); });
        }

        // PUT api/<TransactionController>/5
        [HttpPut]
        public async Task Put(TransactionEditDto transaction)
        {
            var dbTransaction = await Task.Run(() => { return _transactionRepo.GetById(transaction.Id); });
            if (dbTransaction == null)
            {
                //Todo: handle if dbTransaction is null
                return;
            }
            dbTransaction.Date = transaction.Date;
            dbTransaction.PaymentMethod = transaction.PaymentMethod;
            dbTransaction.TotalValue = transaction.TotalValue;
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;
            dbTransaction.TransactionLines = transaction.TransactionLines
                .Select(transactionLine => new TransactionLine(
                    transactionLine.TransactionId,
                    transactionLine.ItemId)
                {
                    Id = transactionLine.Id,
                    Quantity = transactionLine.Quantity,
                    ItemPrice = transactionLine.ItemPrice,
                    NetValue = transactionLine.NetValue,
                    DiscountPercent = transactionLine.DiscountPercent,
                    DiscountValue = transactionLine.DiscountValue,
                    TotalValue = transactionLine.TotalValue,
                }).ToList();

            _transactionRepo.Update(transaction.Id, dbTransaction);
        }

        // DELETE /<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await Task.Run(() => { _transactionRepo.Delete(id); });
                return Ok();
            }
            catch (DbUpdateException)
            {
                return BadRequest($"Could not delete this transaction because it has transactionLines");
            }
            catch (KeyNotFoundException)
            {
                return BadRequest($"Transaction not found");
            }
        }
    }
}

