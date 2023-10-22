using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dindelegan_Andreea_Lab2.Models
{
    public class Book
    {
        [Key]
        [Column("BookID")]
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public int IDAuthor { get; set; }  // Cheie străină către Authors
        public Author Author { get; set; }  // Proprietate de navigare către Authors


        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
    
}
}
