using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public partial class BaseApplication<TSource, TDestination> : IBaseApplication<TSource, TDestination>
        where TSource : BaseEntity
        where TDestination : BaseEntity
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

            _service.Update(destination);

            return source;
        }
    }
}