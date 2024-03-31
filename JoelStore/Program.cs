using JoelStore.Services.JoelStore;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();  
    builder.Services.AddScoped<IStoreService, StoreService>();
}



var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}


