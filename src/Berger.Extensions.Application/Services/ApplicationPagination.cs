using Berger.Extensions.System;
using Berger.Extensions.Pagination;

namespace Berger.Extensions.Application
{
    public partial class ApplicationService<TSource, TDestination> : IApplicationService<TSource, TDestination> where TSource : BaseInput where TDestination : BaseEntity
    {
        public Pagination<TSource> Get(string query, int page = 0)
        {
            var results = _service.Get().Paginate(page, 50);

            return _mapper.Map<Pagination<TSource>>(results);
        }

        public Pagination<TSource> Get(string query, int page = 0, object filters = null)
        {
            // TODO: Apply filters
            var results = _service.Get().Paginate(page, 50);

            return _mapper.Map<Pagination<TSource>>(results);
        }
    }
}