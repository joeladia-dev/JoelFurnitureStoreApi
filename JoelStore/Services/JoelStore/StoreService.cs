using JoelStore.Models;

namespace JoelStore.Services.JoelStore;


public class StoreService : IStoreService
{
    private static readonly Dictionary<Guid, Store> _stores = new();
    
    public void CreateStore(Store store)
    {
        _stores.Add(store.Id, store);
    }

    public void DeleteStore(Guid id)
    {
        _stores.Remove(id);
    }

    public Store GetStore(Guid id)
    {
       return _stores[id];
    }

    public void UpsertStore(Store store)
    {
        _stores[store.Id] = store;
    }
}