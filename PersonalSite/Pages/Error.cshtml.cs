using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace PersonalSite.Pages
{
    /// <summary>
    /// Page model for the generic error page shown when an unhandled exception occurs.
    /// </summary>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        /// <summary>
        /// The current request's trace identifier, shown to help correlate logs.
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// Whether a request ID is available to display.
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        /// <summary>
        /// Handles GET requests for the error page.
        /// </summary>
        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}