using Core.Entities.Abstract;

namespace Entities.TableModels
{
    public class Team : BaseEntity, IEntity
    {
        public string Fullname { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public string LinkedinLink { get; set; }
        public string FacebookLink { get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; }
    }
}
