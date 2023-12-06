using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ProgrammingInApplications.Data;
using ProgrammingInApplications;

public class CreateCreditModel : PageModel
{
    private readonly CreditDbContext _db;

    public CreateCreditModel(CreditDbContext db)
    {
        _db = db;
        Credit = new Credit();
    }

    [BindProperty]
    public Credit Credit { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _db.Credits.Add(Credit);
        await _db.SaveChangesAsync();

        return RedirectToPage("/Index");
    }
}
