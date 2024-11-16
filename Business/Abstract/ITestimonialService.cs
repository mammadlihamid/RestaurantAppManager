using Entities.TableModels;

namespace Business.Abstract
{
    public interface ITestimonialService
    {
        void Add(Testimonial entity);
        void Update(Testimonial entity);
        void Delete(Testimonial entity);
        List<Testimonial> GetAll();
        Testimonial GetById(int id);
    }
}
