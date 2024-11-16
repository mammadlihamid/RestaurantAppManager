using Entities.TableModels;

namespace Business.Abstract
{
    public interface IAboutService
    {
        void Add(About entity);
        void Update(About entity);
        void Delete(About entity);
        List<About> GetAll();
        About GetById(int id);
    }
}
