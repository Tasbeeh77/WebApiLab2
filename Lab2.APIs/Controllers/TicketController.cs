using Lab2.BL.DTOS.Ticket;
using Lab2.BL.Manager.Tickets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketManager ticketManager;

        public TicketController(ITicketManager ticketmanager)
        {
            ticketManager = ticketmanager;
        }
        [HttpGet]
        public ActionResult<List<TicketsSelectDto>> GetAll()
        {
            return ticketManager.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<TicketsSelectDto> GetById(int id)
        {
            TicketsSelectDto? tickets = ticketManager.GetById(id);
            if (tickets == null)
            {
                return NotFound();
            }
            return tickets;
        }
        [HttpPost]
        public ActionResult Add(TicketsAddDto ticket)
        {
            int ticketId = ticketManager.Add(ticket);
            return Ok("created successfully");
        }
        [HttpPut]
        public ActionResult Update(TicketsUpdateDto ticket)
        {
            bool idExist = ticketManager.Update(ticket);
            if (!idExist)
            {
                return NotFound();
            }
            return Ok("Updated successfully");
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            bool IdExist = ticketManager.Delete(id);
            if (!IdExist)
            {
                return NotFound();
            }
            return Ok("Deleted successfully");
        }
    }
}
