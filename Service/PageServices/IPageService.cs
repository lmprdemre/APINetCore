using Dto.PageDtps;
using System.Threading.Tasks;

namespace Service.PageServices
{
    public interface IPageService
    {
        Task<int> CreatePage (CreatePageDto model);
    }
}
