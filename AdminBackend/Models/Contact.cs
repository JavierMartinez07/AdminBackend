namespace AdminBackend.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Address { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int CustomerId { get; set; }

    }
}
