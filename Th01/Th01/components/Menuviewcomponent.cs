using Microsoft.AspNetCore.Mvc;
using TH01.Models;
namespace TH01.components
{
    public class Menuviewcomponent : ViewComponent
    {
        private DataContext _context;
        public Menuviewcomponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listoFMenu = (from m in _context.Menus
                              where (m.IsActive == true) && (m.Position == 1)
                              select m).ToList();
            return await Task.FromResult(listoFMenu(IViewComponentResult)View("Default", listoFMenu));
        }
    }
}
