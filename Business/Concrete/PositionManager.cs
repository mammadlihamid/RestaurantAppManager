using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.TableModels;

namespace Business.Concrete
{
    public class PositionManager : IPositionService
    {
        IPositionDal _positionDal = new PositionDal();
        public void Add(Position entity)
        {
            _positionDal.Add(entity);
        }

        public void Delete(Position entity)
        {
            _positionDal.Delete(entity);
        }

        public List<Position> GetAll()
        {
            return _positionDal.GetAll();
        }

        public Position GetById(int id)
        {
            return _positionDal.GetById(id);
        }

        public void Update(Position entity)
        {
            _positionDal.Update(entity);
        }
    }
}
