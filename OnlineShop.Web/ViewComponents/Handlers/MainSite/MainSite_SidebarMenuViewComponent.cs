using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Web.ViewComponents.Handlers.MainSite;

public class MainSite_SidebarMenuViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        
        return View("/ViewComponents/Views/MainSite/MainSite_SidebarMenuView.cshtml");
    }
}

