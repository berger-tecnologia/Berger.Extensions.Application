using Berger.Extensions.Entities;

namespace Berger.Extensions.Application
{
    public partial class ApplicationService<TSource, TDestination> : IApplicationService<TSource, TDestination> where TSource : BaseInput where TDestination : BaseEntity
    {
        public List<TSource> Get()
        {
            var results = _service.Get();

            return _mapper.Map<List<TSource>>(results);
        }
        public List<TSource> GetBasic()
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