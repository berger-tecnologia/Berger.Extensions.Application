using AutoMapper;
using Berger.Extensions.Domain;
using Berger.Extensions.Entities;

namespace Berger.Extensions.Application
{
    public partial class BaseApplication<TSource, TDestination> : IBaseApplication<TSource, TDestination> where TSource : BaseInput where TDestination : BaseEntity
    {
        #region Properties
        private readonly IMapper _mapper;
        private readonly IBaseService<TDestination> _service;
        #endregion

        #region Constructors
        public BaseApplication(IMapper mapper, IBaseService<TDestination> service)
        {
            _mapper = mapper;
            _service = service;
        }
        #endregion
    }
}