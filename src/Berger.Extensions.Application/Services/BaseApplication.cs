using AutoMapper;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public partial class ApplicationService<TSource, TDestination> : IApplicationService<TSource, TDestination> where TSource : class, IBaseEntity<Guid> where TDestination : class, IBaseEntity<Guid>
    {
        #region Properties
        private readonly IMapper _mapper;
        private readonly IRepository<TDestination> _service;
        #endregion

        #region Constructors
        public ApplicationService(IMapper mapper, IRepository<TDestination> service)
        {
            _mapper = mapper;
            _service = service;
        }
        #endregion
    }
}