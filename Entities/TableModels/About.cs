using Core.Entities.Abstract;

namespace Entities.TableModels
{
    public class About : BaseEntity, IEntity
    {
        public string Description { get; set; }
    }
}
