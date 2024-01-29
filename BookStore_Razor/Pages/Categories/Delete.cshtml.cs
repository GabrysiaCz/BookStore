using BookStore_Razor.Data;
using BookStore_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookStore_Razor.Pages.Kategorie
{
    [BindProperties]
    public class UsunModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public Kategoria Kategoria { get; set; }

        public UsunModel(ApplicationDBContext db)
        {
            _db = db;
        }

        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Kategoria = _db.Kategorie.FirstOrDefault(k => k.Id == id);
            }
        }

        public IActionResult OnPost()
        {
            Kategoria? kategoria = _db.Kategorie.Find(Kategoria.Id);

            if (kategoria == null)
            {
                return NotFound();
            }
            
            _db.Kategorie.Remove(kategoria);
            _db.SaveChanges();
            TempData["success"] = "Kategoria została pomyślnie usunięta";

            return RedirectToPage("Index");
        }
    }
}
