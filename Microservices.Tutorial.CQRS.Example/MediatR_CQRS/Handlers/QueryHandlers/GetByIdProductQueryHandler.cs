using MediatR;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Queries.Requests;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Queries.Responses;
using Microservices.Tutorial.CQRS.Example.Models;

namespace Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(p => p.Id == request.ProductId);

            return new GetByIdProductQueryResponse
            {
                CreateTime = product.CreateTime,
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            };

        }
    }
}
