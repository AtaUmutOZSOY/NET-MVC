namespace WebApp.Models
{
    public class Candidate
    {
        public string Email { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {MiddleName} {LastName?.ToUpper()}";
        public int Age { get; set; } = 0;

        public string SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt  { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}
