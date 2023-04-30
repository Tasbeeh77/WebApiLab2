using Lab2.BL.DTOS.Depatment;
using Lab2.BL.DTOS.Ticket;
using Lab2.DAL.Data.Models;
using Lab2.DAL.Repos.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.BL.Manager.Departments
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IDepartmentRepo _dept;

        public DepartmentManager(IDepartmentRepo dept)
        {
            _dept = dept;
        }
        public DepartmentDto? GetById(int id)
        {
            Department? department = _dept.GetById(id);
            if (department == null)
            {
                return null;
            }
            return new DepartmentDto
            {
                Id = department.Id,
                Name = department.Name,
                Tickets = department.Tickets
                .Select(dt => new TicketDeveloperDto
                {
                    Id = dt.Id,
                    Title = dt.Title,
                    Description = dt.Description,
                    DeveloperCount = dt.Developers.Count,
                }).ToList()
            };
        }
    }
}

