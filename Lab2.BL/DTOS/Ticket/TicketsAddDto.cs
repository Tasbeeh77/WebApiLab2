using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.BL.DTOS.Ticket
{
    public class TicketsAddDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public int departmentId { get; set; }
    }
}
