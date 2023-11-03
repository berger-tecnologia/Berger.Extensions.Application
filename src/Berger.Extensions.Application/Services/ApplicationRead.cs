using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public partial class ApplicationService<TSource, TDestination> : IApplicationService<TSource, TDestination> where TSource : class, IBaseInput where TDestination : class, IBaseEntity
    {
        public List<TSource> Get()
        {
            var results = _service.Get();

            return _mapper.Map<List<TSource>>(results);
        }
        public TSource GetById(Guid id)
        {
            var result = _service.GetById(id);

            return _mapper.Map<TSource>(result);
        }
    }
}