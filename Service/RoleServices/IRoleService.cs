using Dto.RoleDtos;
using System.Threading.Tasks;

namespace Service.RoleServices
{
    public interface IRoleService
    {
        Task<int> CreateRole(CreateRoleDto model);
    }
}
