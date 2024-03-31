using Microsoft.AspNetCore.Mvc;
using JoelStore.Contracts.Store;
using JoelStore.Models;
using JoelStore.Services.JoelStore;


namespace JoelStore.StoreController;

[ApiController]
[Route("[controller]")]
    public class StoreController : ControllerBase
    {   
        
        private readonly IStoreService _storeService;

            public StoreController(IStoreService storeService)
            {
                _storeService = storeService;
            }

            [HttpPost]
            public IActionResult CreateStore(CreateStoreRequest request)
            {
                var store = new Store(
                    Guid.NewGuid(),
                    request.Name,
                    request.Description, 
                    request.StartDateTime, request.EndDateTime, 
                    DateTime.UtcNow,
                    request.Companies,
                    request.Furnitures);

                _storeService.CreateStore(store);    

                var response = new StoreResponse(
                    store.Id,
                    store.Name,
                    store.Description,
                    store.StartDateTime,
                    store.EndDateTime,
                    store.LastModifiedDateTime,
                    store.Companies,
                    store.Furnitures
                );
                return CreatedAtAction(
                    actionName: nameof(GetStore),
                    routeValues: new { id = store.Id },
                    value: response);
            }

            [HttpGet("{id:guid}")]
            public IActionResult GetStore(Guid id)
            {
                Store store = _storeService.GetStore(id);

                var response = new StoreResponse(
                    store.Id,
                    store.Name,
                    store.Description,
                    store.StartDateTime,
                    store.EndDateTime,
                    store.LastModifiedDateTime,
                    store.Companies,
                    store.Furnitures
                );
                return Ok(response);
            }

            [HttpPut("{id:guid}")]
            public IActionResult UpsertStore(Guid id, UpsertStoreRequest request)
            {
            var store = new Store(
                    id,
                    request.Name,
                    request.Description, 
                    request.StartDateTime, request.EndDateTime, 
                    DateTime.UtcNow,
                    request.Companies,
                    request.Furnitures  
            );
            _storeService.UpsertStore(store);
            
            return NoContent();

            }

            [HttpDelete("{id:guid}")]
            public IActionResult DeleteStore(Guid id)
            {
                _storeService.DeleteStore(id);
                return NoContent();
            }

    };
