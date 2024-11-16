using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.TableModels;

namespace DataAccess.Concrete
{
    public class TestimonialDal : RepositoryBase<Testimonial, ApplicationDbContext>, ITestimonialDal { }

}
