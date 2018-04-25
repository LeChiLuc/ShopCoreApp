using Microsoft.AspNetCore.Mvc;
using ShopCoreApp.Application.Interfaces;
using ShopCoreApp.Application.ViewModels.System;
using ShopCoreApp.Extensions;
using ShopCoreApp.Utilities.Constants;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ShopCoreApp.Areas.Admin.Components
{
    public class SideBarViewComponent : ViewComponent
    {
        private IFunctionService _functionService;

        public SideBarViewComponent(IFunctionService functionService)
        {
            _functionService = functionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var roles = ((ClaimsPrincipal)User).GetSpecificClaim("Roles");
            List<FunctionViewModel> functions;
            if (roles.Split(";").Contains(CommonConstants.AdminRole))
            {
                functions = await _functionService.GetAll(string.Empty);
            }
            else
            {
                //TODO: Get by permission
                functions = new List<FunctionViewModel>();
            }
            return View(functions);
        }
    }
}