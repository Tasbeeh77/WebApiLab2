using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.BL.DTOS.Ticket
{
    public class TicketDeveloperDto
    {
        public int Id { get; set; }
        public required string Title { get; set; } 
        public required string Description { get; set; } 
        public int DeveloperCount { get; set; }
    }
}
