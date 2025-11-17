using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Web.ViewComponents.Handlers.MainSite;

public class MainSite_SectionTitleViewComponent : ViewComponent
{
    public record SectionTitleViewModel(string Title, string Description);

    public IViewComponentResult Invoke(string title, string description)
    {
        
        return View("/ViewComponents/Views/MainSite/MainSite_SectionTitleView.cshtml", new SectionTitleViewModel(title, description));
    }
}

