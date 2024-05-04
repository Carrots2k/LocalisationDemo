using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace LocalBlazor.Controllers;

[Route("[Controller]/[action]")]
public class CultureController : Controller
{
    public IActionResult setCulture(string culture, string redirectUri)
    {
         if(culture != null)
         {
            HttpContext.Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(
                    new RequestCulture(culture)));
         }

         return LocalRedirect(redirectUri);
    }
}
