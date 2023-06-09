using System.ComponentModel.DataAnnotations;

namespace WebApp1MvcCrud.Models
{
    public class Student
    {

        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public short Age { get; set; }
        public DateTime RegDate { get; set; }     
        public float Grade { get; set; }


    }
}
