using FactoryInjection.Entitis;

namespace FactoryInjection.Services.Parts
{
    /// <summary>
    /// 私有雲料件Service
    /// </summary>
    public class PrivatePartService : IPartService
    {
        private IList<Part> FakeData = new List<Part>
        {
            new Part
            {
                Id = 1,
                Name = "Private-Part-1",
            },
            new Part
            {
                Id = 2,
                Name = "Private-Part-2",
            }
        };

        ///<inheritdoc/>
        public IEnumerable<Part> Get()
        {
            return FakeData;
        }
    }
}
