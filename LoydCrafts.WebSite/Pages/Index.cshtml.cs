using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Services;
using ReuseSU.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ReuseSU.WebSite.Pages
{
    /// <summary>
    /// Code repository for the Index.cshtml page.  Any code needed for this page should go here.
    /// </summary>
    public class IndexModel : PageModel
    {
        // Aggregates most logging patterns to a single method
        private readonly ILogger<IndexModel> _logger;

        // Keeps track of products to sell on crafts website from Json file
        public JsonFileProductService ProductService;

        /// <summary>
        /// Function to keep track of products and allows the getting and setting
        /// </summary>
        public IEnumerable<Product> Products { get; private set; }

        /// <summary>
        /// Constructor to create a new index model
        /// </summary>
        /// <param name="logger">
        /// The logger to keep track of products
        /// </param>
        /// <param name="productService">
        /// The product service to load files from the Json
        /// </param>
        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        /// <summary>
        /// Initializes the state needed for the page
        /// </summary>
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
