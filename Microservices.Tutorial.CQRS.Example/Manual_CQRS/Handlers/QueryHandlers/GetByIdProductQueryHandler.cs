using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Queries.Requests;
using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Queries.Responses;
using Microservices.Tutorial.CQRS.Example.Models;

namespace Microservices.Tutorial.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest request)
        {
            var findProduct = ApplicationDbContext.ProductList.FirstOrDefault(p => p.Id == request.ProductId);


            return new GetByIdProductQueryResponse
            {
                Id = findProduct.Id,
                CreateTime = findProduct.CreateTime,
                Name = findProduct.Name,
                Quantity = findProduct.Quantity,
                Price = findProduct.Price
            };

        }
    }
}
