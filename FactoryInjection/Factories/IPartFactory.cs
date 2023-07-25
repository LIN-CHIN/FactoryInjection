using FactoryInjection.Enums;
using FactoryInjection.Services.Parts;

namespace FactoryInjection.Factories
{
    /// <summary>
    /// 料件工廠 Interface
    /// </summary>
    public interface IPartFactory
    {
        /// <summary>
        /// 建立一個料件服務
        /// </summary>
        /// <param name="cloudServiceType">雲端服務類型</param>
        /// <returns></returns>
        IPartService New(CloudServiceType cloudServiceType);
    }
}
