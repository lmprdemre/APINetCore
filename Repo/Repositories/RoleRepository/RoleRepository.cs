using Repo.Context;
using Repo.Domain;

namespace Repo.Repositories.RoleRepository
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(EmreDbContext dbContext) : base(dbContext)
        {

        }
    }
}
