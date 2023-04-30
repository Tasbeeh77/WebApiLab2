using Lab2.BL.DTOS.Ticket;
using Lab2.DAL.Data.Models;
using Lab2.DAL.Repos.Tickets;

namespace Lab2.BL.Manager.Tickets
{
    public class TicketManager : ITicketManager
    {
        private readonly ITicketRepo _repo;
        public TicketManager(ITicketRepo repo) { 
            _repo = repo;
        }
        public int Add(TicketsAddDto ticket)
        {
            Ticket tickets = new Ticket
            {
                Title = ticket.Title,
                Description = ticket.Description,
                departmentId = ticket.departmentId,
            };
            _repo.Add(tickets);
            _repo.SaveChanges();
            return tickets.Id;
        }

        public bool Delete(int id)
        {
            Ticket? tickets = _repo.GetById(id);
            if (tickets == null)
            {
                return false;
            }
            _repo.Delete(tickets);
            _repo.SaveChanges();
            return true;
        }

        public List<TicketsSelectDto> GetAll()
        {
            IEnumerable<Ticket> tickets= _repo.GetAll();
            return tickets.Select(t => new TicketsSelectDto
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                departmentId = t.departmentId,
            }).ToList();
        }

        public TicketsSelectDto? GetById(int id)
        {
            Ticket? tickets = _repo.GetById(id);
            if (tickets == null)
            {
                return null;
            }
            return new TicketsSelectDto
            {
                Id = id,
                Title = tickets.Title,
                Description = tickets.Description,
                departmentId = tickets.departmentId,
            };
        }

        public bool Update(TicketsUpdateDto ticket)
        {
            Ticket? tickets = _repo.GetById(ticket.Id);
            if (tickets == null)
            {
                return false;
            }
                
            ticket.Title = tickets.Title;
            ticket.Description = tickets.Description;
            ticket.departmentId = tickets.departmentId;
            _repo.SaveChanges();

            return true;
        }
    }
}
