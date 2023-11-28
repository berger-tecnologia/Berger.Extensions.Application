using AutoMapper;
using Berger.Extensions.Domain;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public class BaseApplication<TSource, TDestination, TService> : ApplicationService<TSource, TDestination>
        where TSource : BaseEntity
        where TDestination : BaseEntity
        where TService : IBaseService<TDestination>
    {
        #region Properties
        private readonly IMapper _mapper;
        private readonly TService _service;
        #endregion

        #region Constructors
        public BaseApplication(IMapper mapper, TService service) : base(mapper, service) { }
        #endregion
    }
}