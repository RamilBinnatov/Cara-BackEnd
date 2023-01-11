using FinalProject.Data;
using FinalProject.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly LayoutService _layoutService;
        private readonly AppDbContext _context;

        public HeaderViewComponent(LayoutService layoutService, AppDbContext context)
        {
            _layoutService = layoutService;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {


            return await Task.FromResult(View());
        }
    }
}
