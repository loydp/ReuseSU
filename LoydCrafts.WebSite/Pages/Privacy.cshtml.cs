using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ReuseSU.WebSite.Pages
{
    /// <summary>
    /// Code repository for the Privacy.cshtml.  Any code needed for this page should go here.
    /// </summary>
    public class PrivacyModel : PageModel
    {
        // Aggregates most logging patterns to a single method
        private readonly ILogger<PrivacyModel> _logger;

        /// <summary>
        /// Constructor for the Privacy page to create a new privacy model
        /// </summary>
        /// <param name="logger"></param>
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Initializes the state needed for the page
        /// </summary>
        public void OnGet()
        {
        }
    }
}
