using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ReuseSU.WebSite.Pages
{
    /// <summary>
    /// Configure the response caching; this is also a code repository for error.cshtml.
    /// All code needed to run error.cshmtl should go in this class.
    /// </summary>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {
        /// <summary>
        /// Function to keep track of RequestIds.  Allows for getting and setting.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Function to show the status of the RequestID, if it's null or empty
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        // Aggregates most logging patters to a single method
        private readonly ILogger<ErrorModel> _logger;

        /// <summary>
        /// Constructor which creaets the new error model
        /// </summary>
        /// <param name="logger">
        /// The logger to keep track of errors
        /// </param>
        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Initializes the state needed for the page and sets the RequestID
        /// </summary>
        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}
