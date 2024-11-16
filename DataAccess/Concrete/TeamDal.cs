using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.TableModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class TeamDal : RepositoryBase<Team, ApplicationDbContext>, ITeamDal
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public List<Team> GetAllTeams()
        {
            return _context.Teams
                .Include(x=>x.Position)
                .Where(x=> x.Deleted==0)
                .ToList();
        }
    }

}
