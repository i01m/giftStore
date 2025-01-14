﻿using Microsoft.AspNetCore.Mvc;
using GiftsForEveryone.Models;
using System.Linq;
using GiftsForEveryone.Models.ViewModels;

namespace GiftsForEveryone.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 6;

        public ProductController(IProductRepository repo)
        { repository = repo; }

        public ViewResult List(string category, int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,

                    TotalItems = category == null ?
                    repository.Products.Count() :
                    repository.Products.Where(e => e.Category == category)
                     .Count()
                },
                CurrentCategory = category
            });
    }
}