using Lab2.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2.DAL.Repos.Departments
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly DbContext context;
        public DepartmentRepo(DbContext DevContext) { 
            context = DevContext;
        }
        public Department? GetById(int id)
        {
            return context.Set<Department>().Include(d => d.Tickets)
                     .ThenInclude(p => p.Developers.Count)
                     .FirstOrDefault(a=> a.Id == id);
        }
        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
