using MediatR;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Commands.Requests;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Commands.Responses;
using Microservices.Tutorial.CQRS.Example.Models;

namespace Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            ApplicationDbContext.ProductList.Add(new()
            {
                Id = id,
                CreateTime = DateTime.Now,
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity
            });

            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = id,
            };

        }
    }
}
