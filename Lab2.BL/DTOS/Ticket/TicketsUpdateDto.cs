using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.BL.DTOS.Ticket
{
    public class TicketsUpdateDto
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; }
        public int departmentId { get; set; }
    }
}
