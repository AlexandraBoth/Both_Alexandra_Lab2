using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Security.Policy;

namespace Both_Alexandra_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = "Titlu cărții trebuie să înceapă cu majuscula. 3-150 carectere")]
        [StringLength(150, MinimumLength = 3)]
        public string Title { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")] [Range(0.01, 500)]
        public decimal Price { get; set; }
        [DataType(DataType.Date)] 
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }

    }
}
