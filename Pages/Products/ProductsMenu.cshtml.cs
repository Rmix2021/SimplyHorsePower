using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SimplyHorsePower.Models;
using SimplyHorsePower.Data;
using SimplyHorsePower.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;


namespace SimplyHorsePower.Pages.Products
{
    [Authorize("AdminOnly")]
    public class ProductsMenuModel : PageModel
    {
        [BindProperty]
        public List<Product> Products { get; set; }
        [BindProperty]
        public Product product { get; set; }

        [BindProperty]
        public string makeName { get; set; }

        [BindProperty]
        public string categoryName { get; set; }      

        [BindProperty]
        public Make Make { get; set; }

        [BindProperty]
        public Category Category { get; set; }       

        public List<SelectListItem> CategoryDropdownList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> MakeDropdownList { get; set; } = new List<SelectListItem>();

        private readonly ProductService _service;
        private readonly CategoryService _categoryservice;
        private readonly MakeService _makeservice;
        private readonly ILogger<ProductsMenuModel> _logger;
        public ApplicationDbContext _context;

        public ProductsMenuModel(ProductService service, ILogger<ProductsMenuModel> logger, ApplicationDbContext context, CategoryService categoryservice, MakeService makeservice)
        {
            _service = service;
            _makeservice = makeservice;
            _categoryservice = categoryservice;
            _logger = logger;
            _context = context;

        }

        public void OnGet()
        {
            CategoryDropdownList = _categoryservice.CategoryDropDownList();
            CategoryDropdownList.Insert(0, new SelectListItem("Select one", null, false));
            MakeDropdownList = _makeservice.MakeDropDownList();
            MakeDropdownList.Insert(0, new SelectListItem("Select one", null, false));
            Products = _service.GetAllProducts();
            
        }

        public void OnPost()
        {

            if (makeName != "Select one" && categoryName == "Select one")
            {
                Products = _service.GetFilteredProductsByMake(makeName);
            }
            else if (categoryName != "Select one" && makeName == "Select one")
            {
                Products = _service.GetFilteredProductsByCategory(categoryName);
            }
            else if (makeName != "Select one" && categoryName != "Select one")
            {
                Products = _service.GetFilteredProductsByCatMake(categoryName, makeName);
            }
            else
            {
                RedirectToPage("../Products/ProductsMenu");
            }
        }
        
    }
}
