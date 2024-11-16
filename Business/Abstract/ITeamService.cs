using Entities.TableModels;

namespace Business.Abstract
{
    public interface ITeamService
    {
        void Add(Team entity);
        void Update(Team entity);
        void Delete(Team entity);
        List<Team> GetAll();
        Team GetById(int id);
    }
}
