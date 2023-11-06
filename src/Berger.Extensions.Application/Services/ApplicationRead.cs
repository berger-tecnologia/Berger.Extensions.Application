using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public partial class ApplicationService<TSource, TDestination> : IApplicationService<TSource, TDestination> where TSource : class, IBaseEntity<Guid> where TDestination : class, IBaseEntity<Guid>
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