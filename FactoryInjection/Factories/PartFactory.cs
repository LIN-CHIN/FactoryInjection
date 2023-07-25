using FactoryInjection.Enums;
using FactoryInjection.Services.Parts;

namespace FactoryInjection.Factories
{
    /// <summary>
    /// 料件工廠
    /// </summary>
    public class PartFactory : IPartFactory
    {
        private IServiceProvider _serviceProvider;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serviceProvider"></param>
        public PartFactory(IServiceProvider serviceProvider) 
        {
            _serviceProvider = serviceProvider;
        }

        ///<inheritdoc/>
        public IPartService New(CloudServiceType cloudServiceType)
        {
            //公有雲Service
            if (cloudServiceType == CloudServiceType.Public)
            {
                return (IPartService)_serviceProvider.GetService(typeof(PublicPartService))!;
            }
            //私有雲Service
            else if (cloudServiceType == CloudServiceType.Private) 
            {
                return (IPartService)_serviceProvider.GetService(typeof(PrivatePartService))!;
            }
            else 
            {
                throw new Exception("Part Factory Error");
            }
        }
    }
}
