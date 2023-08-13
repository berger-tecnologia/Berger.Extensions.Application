using Berger.Extensions.Entities;
using Berger.Extensions.Pagination;

namespace Berger.Extensions.Application
{
    public interface IApplicationService<TSource, TDestination> : IPagination<TSource> where TSource : BaseInput where TDestination : BaseEntity
    {
        TSource GetById(Guid id);
        List<TSource> Get();
        List<TSource> GetBasic();
        TSource Add(TSource source);
        TSource Update(TSource source);
        void Delete(Guid id);
    }
}