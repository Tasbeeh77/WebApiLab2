using Lab2.DAL.Data.Models;

namespace Lab2.DAL.Repos.Departments
{
    public interface IDepartmentRepo
    {
        Department? GetById(int id);
        int SaveChanges();
    }
}
