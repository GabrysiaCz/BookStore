using BookStore_Razor.Data;
using BookStore_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore_Razor.Pages.Kategorie
{
    [BindProperties]
    public class UtwórzModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public Kategoria Kategoria { get; set; }

        public UtwórzModel(ApplicationDBContext db)
        {
            _db = db;
        }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Kategoria != null)
            {
                _db.Kategorie.Add(Kategoria);
                _db.SaveChanges();
                TempData["success"] = "Kategoria została pomyślnie utworzona";
                return RedirectToPage("Index");
            }
            return NotFound();
        }
    }
}
