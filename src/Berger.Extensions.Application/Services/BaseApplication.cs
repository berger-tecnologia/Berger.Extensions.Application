using AutoMapper;
using Berger.Extensions.Base;
using Berger.Extensions.Domain;

namespace Berger.Extensions.Application
{
    public partial class ApplicationService<TSource, TDestination> : IApplicationService<TSource, TDestination> where TSource : BaseInput where TDestination : BaseEntity
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