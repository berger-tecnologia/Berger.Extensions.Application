using Berger.Extensions.Entities;

namespace Berger.Extensions.Application
{
    public interface IBaseApplication<TSource, TDestination> where TSource : BaseInput where TDestination : BaseEntity
    {
        TSource GetById(Guid id);
        List<TSource> Get();
        List<TSource> GetBasic();
        TSource Add(TSource source);
        TSource Update(TSource source);
        void Delete(Guid id);
    }
}