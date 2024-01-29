using BookStore_Razor.Data;
using BookStore_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookStore_Razor.Pages.Kategorie
{
    [BindProperties]
    public class EdytujModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public Kategoria Kategoria { get; set; }

        public EdytujModel(ApplicationDBContext db)
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
            if (ModelState.IsValid)
            {
                _db.Kategorie.Update(Kategoria);
                _db.SaveChanges();
                TempData["success"] = "Kategoria została pomyślnie zaktualizowana";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
