using System.ComponentModel.DataAnnotations;

namespace Dindelegan_Andreea_Lab2.Models
{
    public class Author
    {
        [Key]
        public int IDAuthor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
