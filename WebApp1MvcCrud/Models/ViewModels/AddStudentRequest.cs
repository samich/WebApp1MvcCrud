namespace WebApp1MvcCrud.Models.ViewModels
{
    public class AddStudentRequest
    {
        public string Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public float Grade { get; set; }


    }
}
