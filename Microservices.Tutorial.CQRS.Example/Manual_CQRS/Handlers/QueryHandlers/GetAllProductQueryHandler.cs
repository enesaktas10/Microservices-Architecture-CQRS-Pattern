using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Queries.Requests;
using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Queries.Responses;
using Microservices.Tutorial.CQRS.Example.Models;

namespace Microservices.Tutorial.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest request)
        {
            return ApplicationDbContext.ProductList.Select(product => new GetAllProductQueryResponse
            {
                CreateTime = product.CreateTime,
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
            }).ToList();
        }
    }
}
