using FactoryInjection.Entitis;

namespace FactoryInjection.Services.Parts
{
    /// <summary>
    /// 料件Service Interface
    /// </summary>
    public interface IPartService
    {
        /// <summary>
        /// 取得料件
        /// </summary>
        /// <returns></returns>
        IEnumerable<Part> Get();
    }
}
