using AutoMapper;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public class ApplicationService<TSource, TDestination, TService> : BaseApplication<TSource, TDestination>
        where TSource : BaseEntity
        where TDestination : BaseEntity
        where TService : IBaseService<TDestination>
    {
        #region Properties
        private readonly TService _service;
        #endregion

        #region Constructors
        public ApplicationService(IMapper mapper, TService service) : base(mapper, service) { }
        #endregion
    }
}