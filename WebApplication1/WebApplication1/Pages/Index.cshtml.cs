using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public double? Num1 { get; set; }

    [BindProperty]
    public double? Num2 { get; set; }

    public double? Result { get; private set; }

    public void OnGet()
    {
        // This method is executed when the page is initially loaded
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Calculate the sum
        Result = Num1 + Num2;

        return Page();
    }
}
