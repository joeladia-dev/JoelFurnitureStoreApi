namespace JoelStore.Contracts.Store;

public record StoreResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Companies,
    List<string> Furnitures
);
