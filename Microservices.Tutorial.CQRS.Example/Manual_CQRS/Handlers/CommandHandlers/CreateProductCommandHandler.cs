using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Commands.Requests;
using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Commands.Responses;
using Microservices.Tutorial.CQRS.Example.Models;

namespace Microservices.Tutorial.CQRS.Example.Manual_CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler
    {
        public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest request)
        {
            var id = Guid.NewGuid();

            ApplicationDbContext.ProductList.Add(new()
            {
                Id = id,
                CreateTime = DateTime.UtcNow,
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity
            });

            return new CreateProductCommandResponse
            {
                ProductId = id,
                IsSuccess = true
            };
        }
    }
}
