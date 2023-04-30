using Lab2.DAL.Data.Models;
namespace Lab2.DAL.Repos.Tickets
{
    public interface ITicketRepo
    {
        IEnumerable<Ticket> GetAll();
        Ticket? GetById(int id);
        void Add(Ticket entity);
        void Delete(Ticket entity);
        int SaveChanges();
    }
}
