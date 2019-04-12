using System;
using System.Threading.Tasks;
using Dto.PageDtps;
using Helper;
using Repo.Domain;
using Repo.Repositories.PageRepository;

namespace Service.PageServices
{
    public class PageService : IPageService
    {
        private readonly IPageRepository _pageRepository;

        public PageService(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }

        public async Task<int> CreatePage(CreatePageDto model)
        {
            if (!ValidationHelper.IsStringsValid(model.Title))
            {
                return -1;
            }

            var page = new Page();
            page.Id = Guid.NewGuid();
            page.Published = true;
            page.Deleted = false;
            page.CreatedBy = "Emre";
            page.Title = model.Title;

            var result = await _pageRepository.Create(page);

            return result;
        }
    }
}
