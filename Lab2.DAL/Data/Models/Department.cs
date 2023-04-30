namespace Lab2.DAL.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();

    }
}
