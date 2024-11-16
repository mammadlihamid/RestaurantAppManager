using Entities.TableModels;

namespace Business.Abstract
{
    public interface IPositionService
    {
        void Add(Position entity);
        void Update(Position entity);
        void Delete(Position entity);
        List<Position> GetAll();
        Position GetById(int id);
    }
}
