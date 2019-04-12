using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dto.RoleDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.RoleServices;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<bool> CreateRole(CreateRoleDto model)
        {
            var result = await _roleService.CreateRole(model);            
            return result == 1;
        }
    }
}