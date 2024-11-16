using Core.Entities.Abstract;

namespace Entities.TableModels
{
    public class Food : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Tag { get; set; }
        public decimal Price { get; set; }
    }
}
