using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.TableModels;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal = new AboutDal();
        public void Add(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void Delete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public List<About> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public About GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
