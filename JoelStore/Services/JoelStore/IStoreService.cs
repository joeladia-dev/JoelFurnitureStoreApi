using JoelStore.Models;

namespace JoelStore.Services.JoelStore;


public interface IStoreService
{
    void CreateStore(Store store);
    void DeleteStore(Guid id);
    Store GetStore(Guid id);
    void UpsertStore(Store store);
}