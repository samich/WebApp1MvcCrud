namespace WebApp1MvcCrud.Models.ViewModels
{
    public class AddStudentRequest
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public short Age { get; set; }
        public float Grade { get; set; }

    }
}
