using showdebola_api.entity.Entity;
using showdebola_api.repository.Repository.Base;

namespace showdebola_api.repository.Repository
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(IDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
