using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Handlers.CommandHandlers;
using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

#region Manual CQRS
builder.Services.AddSingleton<CreateProductCommandHandler>()
                .AddSingleton<DeleteProductCommandHandler>()
                .AddSingleton<GetAllProductQueryHandler>()
                .AddSingleton<GetByIdProductQueryHandler>();
#endregion

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
