using Fuel.Solution.EF.Repositories;
using Fuel.Station.Blazor.Shared;
using Fuel.Station.Model;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Fuel.Station.Blazor.Server.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        // Properties
        private readonly IEntityRepo<Item> _itemRepo;
        //private readonly IValidator _validator;
        private String _errorMessage;

        // Constructors
        public ItemController(IEntityRepo<Item> itemRepo/*, IValidator validator*/)
        {
            _itemRepo = itemRepo;
            _errorMessage = String.Empty;
            //_validator = validator;
        }

        // GET: /<ItemController>
        [HttpGet]
        public async Task<IEnumerable<ItemListDto>> Get()
        {
            var result = await Task.Run(() => { return _itemRepo.GetAll(); });
            var selectItemList = result.Select(item => new ItemListDto
            {
                Id = item.Id,
                Code= item.Code,
                Description= item.Description,
                itemType=item.itemType,
                Price= item.Price,
                Cost= item.Cost,
            });
            return selectItemList;
        }

        // GET: /<ItemController>/5
        [HttpGet("{id}")]
        public async Task<ItemEditDto?> GetById(int id)
        {
            var result = await Task.Run(() => { return _itemRepo.GetById(id); });
            if (result == null)
            {
                return null;
            }
            ItemEditDto item = new ItemEditDto
            {
                Id = result.Id,
                Code = result.Code,
                Description = result.Description,
                itemType = result.itemType,
                Price = result.Price,
                Cost = result.Cost,
            };
            return item;
        }

        // POST /<ItemController>
        [HttpPost]
        public async Task<ActionResult> Post(ItemEditDto item)
        {
            var newItem = new Item(item.Code, item.Description, item.itemType)
            {
                Price = item.Price,
                Cost = item.Cost,
            };
            await Task.Run(() => { _itemRepo.Add(newItem); });
            return Ok();
            //if (_validator.ValidateAddEmployee(_employeeRepo.GetAll().ToList(), out _errorMessage))
            //{
            //    try
            //    {
            //        await Task.Run(() => { _employeeRepo.Add(newEmployee); });
            //        return Ok();
            //    }
            //    catch (DbException ex)
            //    {
            //        return BadRequest(ex.Message);
            //    }
            //}
            //else
            //{
            //    return BadRequest(_errorMessage);
            //}
        }

        // PUT /<ItemController>/5
        [HttpPut]
        public async Task Put(ItemEditDto item)
        {
            var dbItem = await Task.Run(() => { return _itemRepo.GetById(item.Id); });
            if (dbItem == null)
            {
                // TODO if employee is null
                return;
            }
            dbItem.Code = item.Code;
            dbItem.Description = item.Description;
            dbItem.itemType = item.itemType;
            dbItem.Price = item.Price;
            dbItem.Cost = item.Cost;
            _itemRepo.Update(item.Id, dbItem);
        }

        // DELETE /<ItemController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await Task.Run(() => {
                _itemRepo.Delete(id);
            });
        }
    }
}
