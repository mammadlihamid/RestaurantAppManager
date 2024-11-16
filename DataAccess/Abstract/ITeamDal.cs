using Core.DataAccess.Abstract;
using Entities.TableModels;

namespace DataAccess.Abstract
{
    public interface ITeamDal : IBaseRepository<Team> 
    {
        List<Team> GetAllTeams();
    }
}
