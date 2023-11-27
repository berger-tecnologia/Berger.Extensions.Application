using AutoMapper;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public partial class BaseApplication<TSource, TDestination> : IBaseApplication<TSource, TDestination> where TSource : class, IBaseEntity<Guid> where TDestination : class, IBaseEntity<Guid>
    {
        #region Properties
        private readonly IMapper _mapper;
        private readonly IBaseService<TDestination> _service;
        #endregion

        #region Constructors
        public BaseApplication(IMapper mapper, IBaseService<TSource> service) : base(mapper, service)
        {
        }
        #endregion
    }
}