using Microsoft.AspNetCore.Mvc;

namespace GiftsForEveryone.Controllers
{

    public class ErrorController : Controller
    {

        public ViewResult Error() => View();
    }
}