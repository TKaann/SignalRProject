using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutScrpitComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
