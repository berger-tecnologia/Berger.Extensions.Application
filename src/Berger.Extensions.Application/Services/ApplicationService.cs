using AutoMapper;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public class ApplicationService<TSource, TDestination, TService> : BaseApplication<TSource, TDestination>
        where TSource : BaseEntity
        where TDestination : BaseEntity
        where TService : IBaseEntityService<TDestination>
    {
        #region Constructors
        public ApplicationService(IMapper mapper, TService service) : base(mapper, service) { }
        #endregion
    }
}