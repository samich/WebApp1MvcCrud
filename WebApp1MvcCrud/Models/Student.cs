using System.ComponentModel.DataAnnotations;

namespace WebApp1MvcCrud.Models
{
    public class Student
    {

        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public short Age { get; set; }
        public DateTime RegDate { get; set; }     
        public short Grade { get; set; }


    }
}
