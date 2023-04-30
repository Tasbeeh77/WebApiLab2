using Lab2.BL.DTOS.Ticket;

namespace Lab2.BL.Manager.Tickets
{
    public interface ITicketManager
    {
        List<TicketsSelectDto> GetAll();
        TicketsSelectDto? GetById(int id);
        int Add(TicketsAddDto ticket);
        bool Update(TicketsUpdateDto ticket);
        bool Delete(int id);
    }
}
