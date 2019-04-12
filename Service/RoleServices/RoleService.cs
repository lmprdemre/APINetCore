using Dto.RoleDtos;
using Helper;
using Repo.Domain;
using Repo.Repositories.RoleRepository;
using System;
using System.Threading.Tasks;

namespace Service.RoleServices
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<int> CreateRole(CreateRoleDto model)
        {
            if (!ValidationHelper.IsStringsValid(model.Name))
            {
                return -1;
            }

            var role = new Role();
            role.Id = Guid.NewGuid();
            role.Published = true;
            role.Deleted = false;
            role.CreatedBy = "Emre";
            role.Name = model.Name;

            var result = await _roleRepository.Create(role);

            return result;
        }
    }
}
