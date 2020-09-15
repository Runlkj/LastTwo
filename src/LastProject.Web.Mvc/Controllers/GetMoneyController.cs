using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using LastProject.All.GetMoney;
using LastProject.Authorization;
using LastProject.Controllers;
using LastProject.Web.Models.GetMoney;
using Microsoft.AspNetCore.Mvc;

namespace LastProject.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_GetMoney)]
    public class GetMoneyController : LastProjectControllerBase
    {
        private readonly IGetMoneyAppService _getmoneyAppService;
        const int MaxNum = 10;
        public GetMoneyController(IGetMoneyAppService getmoneyAppService)
        {
            _getmoneyAppService = getmoneyAppService;
        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var getmoneys = (await _getmoneyAppService.GetAllAsync(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            // Paging not implemented yet
            var model = new GetMoneyListViewModel
            {
                GetMoneys = getmoneys
            };
            return View(model);
        }

        public async Task<ActionResult> EditCourseModal(int courseId)
        {
            var getmoneys = await _getmoneyAppService.GetAsync(new EntityDto<int>(courseId));
            var model = new EditGetMoneyModalViewModel
            {
                GetMoney = getmoneys
            };
            return View("_EditGetMoneyModal", model);
        }
    }
}