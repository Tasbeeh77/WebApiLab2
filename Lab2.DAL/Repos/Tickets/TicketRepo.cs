using Lab2.DAL.Data.Context;
using Lab2.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2.DAL.Repos.Tickets
{
    public class TicketRepo : ITicketRepo
    {
        private readonly DevContext context;
        public TicketRepo(DevContext devContext) {
            context = devContext;
        }
        public void Add(Ticket entity)
        {
             context.Set<Ticket>().Add(entity);
        }

        public void Delete(Ticket entity)
        {
            context.Set<Ticket>().Remove(entity);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return context.Set<Ticket>().AsNoTracking();
        }

        public Ticket? GetById(int id)
        {
            return context.Set<Ticket>().Find(id);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
