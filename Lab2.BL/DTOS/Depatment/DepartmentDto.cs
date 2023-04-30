using Lab2.BL.DTOS.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.BL.DTOS.Depatment
{
    public class DepartmentDto
    {
        public required int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public ICollection<TicketDeveloperDto> Tickets { get; set; } = new HashSet<TicketDeveloperDto>();
    }
}

