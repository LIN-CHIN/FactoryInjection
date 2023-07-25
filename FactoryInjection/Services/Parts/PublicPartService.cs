using FactoryInjection.Entitis;

namespace FactoryInjection.Services.Parts
{
    /// <summary>
    /// 公有雲料件Service
    /// </summary>
    public class PublicPartService : IPartService
    {
        private IList<Part> FakeData = new List<Part>
        {
            new Part
            {
                Id = 1,
                Name = "Public-Part-1",
            },
            new Part
            {
                Id = 2,
                Name = "Public-Part-2",
            }
        };

        ///<inheritdoc/>
        public IEnumerable<Part> Get()
        {
            return FakeData;
        }
    }
}
