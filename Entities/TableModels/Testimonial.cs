using Core.Entities.Abstract;
using System.Reflection.Metadata.Ecma335;

namespace Entities.TableModels
{
    public class Testimonial : BaseEntity, IEntity
    {
        public string Fullname { get; set; }
        public string Message { get; set; }
        public string Position { get; set; }
    }
}
