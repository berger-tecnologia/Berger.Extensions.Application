using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public partial class BaseApplication<TSource, TDestination> : BaseApplicationGet<TSource>, IBaseApplication<TSource, TDestination> where TSource : class, IBaseEntity<Guid> where TDestination : class, IBaseEntity<Guid>
    {
    }
}