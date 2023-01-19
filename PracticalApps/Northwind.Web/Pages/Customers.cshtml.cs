using Microsoft.AspNetCore.Mvc.RazorPages; // PageModel
using Packt.Shared; // NorthwindContext
using Microsoft.AspNetCore.Mvc; // [BindProperty], IActionResult

namespace Northwind.Web.Pages;
public class CustomersModel : PageModel
{
    public IEnumerable<Customer>? Customers { get; set; }
    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Customers";
        Customers = db.Customers.OrderBy(c => c.Country).ThenBy(c => c.CompanyName);
    }

    private NorthwindContext db;
    public CustomersModel(NorthwindContext injectedContext)
    {
        db = injectedContext;
    }

    [BindProperty]
    public Customer? Customer { get; set; }
    public IActionResult OnPost()
    {
        if ((Customer is not null) && ModelState.IsValid)
        {
            db.Customers.Add(Customer);
            db.SaveChanges();
            return RedirectToPage("/Customers");
        }
        else
        {
            return Page(); // return to original page
        }
    }
}