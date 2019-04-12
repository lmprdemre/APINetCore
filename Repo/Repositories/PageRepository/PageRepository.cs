using Repo.Context;
using Repo.Domain;


namespace Repo.Repositories.PageRepository
{
    public class PageRepository : GenericRepository<Page>, IPageRepository
    {
        public PageRepository(EmreDbContext dbContext) : base(dbContext)
        {

        }
    }
}
