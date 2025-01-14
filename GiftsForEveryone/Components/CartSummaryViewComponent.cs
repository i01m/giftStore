//using Microsoft.AspNetCore.Mvc;
//using GiftsForEveryone.Models;


//namespace GiftsForEveryone.Components
//{
//    public class CartSummaryViewComponent : ViewComponent
//    {
//        private Cart cart;

//        public CartSummaryViewComponent (Cart cartService)
//        {
//            cart = cartService;
//        }

//        public IViewComponentResult Invoke()
//        {
//            return View(cart);
//        }
//    }
//}

using Microsoft.AspNetCore.Mvc;
using GiftsForEveryone.Models;

namespace GiftsForEveryone.Components
{

    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
