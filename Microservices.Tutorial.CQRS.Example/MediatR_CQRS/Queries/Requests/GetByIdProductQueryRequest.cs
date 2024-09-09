﻿using MediatR;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Queries.Responses;

namespace Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Queries.Requests
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public Guid ProductId { get; set; }
    }
}