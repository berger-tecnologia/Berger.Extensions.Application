using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public partial class ApplicationService<TSource, TDestination> : IApplicationService<TSource, TDestination> where TSource : class, IBaseInput where TDestination : class, IBaseEntity
    {
        public TSource Add(TSource source)
        {
            var destination = _mapper.Map<TDestination>(source);

            _service.Add(destination);

            return source;
        }
        public void Delete(Guid id)
        {
            _service.Delete(id);
        }
        public TSource Update(TSource source)
        {
            var destination = _mapper.Map<TDestination>(source);

            _service.Add(destination);

            return source;
        }
    }
}