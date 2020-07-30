using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestorantManagement.Helper;
using RestorantManagement.Services.Interfaces;
using RestorantManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductsService productsService;

        public ProductController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        public IActionResult ShowMenu(int tableId)
        {
            var dbProducts = productsService.GetAll();

            var viewModel = new MenuViewModel();
            viewModel.Products = dbProducts.Select(x => x.ToProductViewModel()).ToList();
            viewModel.TableId = tableId;

            return View(viewModel);
        }
    }
}
