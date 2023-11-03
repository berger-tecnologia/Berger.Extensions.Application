using AutoMapper;
using Berger.Extensions.Domain;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public partial class ApplicationService<TSource, TDestination> : IApplicationService<TSource, TDestination> where TSource : class, IBaseInput where TDestination : class, IBaseEntity
    {
        #region Properties
        private readonly IMapper _mapper;
        private readonly IBaseService<TDestination> _service;
        #endregion

        #region Constructors
        public ApplicationService(IMapper mapper, IBaseService<TDestination> service)
        {
            _mapper = mapper;
            _service = service;
        }
        #endregion
    }
}