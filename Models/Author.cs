using System.ComponentModel;

namespace Pop_Bianca_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DisplayName("FullName")]
        public string FullName => FirstName + " " + LastName;
    }
}
