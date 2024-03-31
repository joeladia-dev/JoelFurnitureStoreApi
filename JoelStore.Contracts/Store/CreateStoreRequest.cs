namespace JoelStore.Contracts.Store;

public record CreateStoreRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Companies,
    List<string> Furnitures
);



