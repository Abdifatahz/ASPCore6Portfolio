using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class About : PageModel
{
    private readonly ILogger<About> _logger;
    public string Fullname { get; set; }

    // public About(ILogger<About> logger)
    // {
    //     _logger = logger;
    // }

    public void OnGet()
    {
        Fullname = "Abdifatah Abdilahi";
    }
}

