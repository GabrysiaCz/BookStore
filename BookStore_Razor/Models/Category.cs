using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookStore_Razor.Models
{
    public class Kategoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nazwa Kategorii")]
        [MaxLength(30)]
        public string Nazwa { get; set; } = null!;

        [DisplayName("Kolejność Wyświetlania")]
        [Range(1, 100, ErrorMessage = "Kolejność wyświetlania musi być między 1 a 100")]
        public int KolejnośćWyświetlania { get; set; }
    }
}
