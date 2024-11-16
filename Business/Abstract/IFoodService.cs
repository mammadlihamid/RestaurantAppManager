using Entities.TableModels;

namespace Business.Abstract
{
    public interface IFoodService
    {
        void Add(Food entity);
        void Update(Food entity);
        void Delete(Food entity);
        List<Food> GetAll();
        Food GetById(int id);
    }
}
