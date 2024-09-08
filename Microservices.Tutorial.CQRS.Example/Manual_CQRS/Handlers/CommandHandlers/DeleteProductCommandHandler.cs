using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Commands.Requests;
using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Commands.Responses;
using Microservices.Tutorial.CQRS.Example.Models;

namespace Microservices.Tutorial.CQRS.Example.Manual_CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest request)
        {
            var findProduct = ApplicationDbContext.ProductList.FirstOrDefault(x => x.Id == request.ProductId);

            if(findProduct != null)
            {
                ApplicationDbContext.ProductList.Remove(findProduct);

                return new DeleteProductCommandResponse
                {
                    IsSuccess = true
                };
            }

            return new DeleteProductCommandResponse
            {
                IsSuccess = false
            };


        }
    }
}
