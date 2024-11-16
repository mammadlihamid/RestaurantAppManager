using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.TableModels;

namespace Business.Concrete
{
    public class TeamManager : ITeamService
    {
        ITeamDal _teamDal = new TeamDal();
        public void Add(Team entity)
        {
            _teamDal.Add(entity);
        }

        public void Delete(Team entity)
        {
            _teamDal.Delete(entity);
        }

        public List<Team> GetAll()
        {
            return _teamDal.GetAllTeams();
        }

        public Team GetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public void Update(Team entity)
        {
            _teamDal.Update(entity);
        }
    }
}
