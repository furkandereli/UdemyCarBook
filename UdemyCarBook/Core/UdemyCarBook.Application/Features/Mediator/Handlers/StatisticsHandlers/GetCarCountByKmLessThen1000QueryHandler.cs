using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByKmLessThen1000QueryHandler : IRequestHandler<GetCarCountByKmLessThen1000Query, GetCarCountByKmLessThen1000QueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByKmLessThen1000QueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByKmLessThen1000QueryResult> Handle(GetCarCountByKmLessThen1000Query request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmLessThen1000();
            return new GetCarCountByKmLessThen1000QueryResult
            {
                CarCountByKmLessThen1000 = value
            };
        }
    }
}
