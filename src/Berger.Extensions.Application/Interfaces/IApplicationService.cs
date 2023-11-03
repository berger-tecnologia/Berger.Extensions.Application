using Berger.Extensions.Pagination;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public interface IApplicationService<TSource, TDestination> : IPagination<TSource> where TSource : class, IBaseInput where TDestination : IBaseEntity
    {
        TSource GetById(Guid id);
        List<TSource> Get();
        TSource Add(TSource source);
        TSource Update(TSource source);
        void Delete(Guid id);
    }
}