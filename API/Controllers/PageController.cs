using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dto.PageDtps;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.PageServices;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {

        private readonly IPageService _pageService;

        public PageController(IPageService pageService)
        {
            _pageService = pageService;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<bool> CreatePage(CreatePageDto model)
        {
            var result = await _pageService.CreatePage(model);
            return result == 1;
        }

    }
}