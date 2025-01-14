using Microsoft.AspNetCore.Mvc;
using System.Linq;
using GiftsForEveryone.Models;

namespace GiftsForEveryone.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    //generating list of categories
    {
        private IProductRepository repository;
        public NavigationMenuViewComponent(IProductRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            //using RouteData property of ViewComponent to access the request data 
            //to get the value for the currently selected category
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }


    }
}