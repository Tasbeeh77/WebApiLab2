using Lab2.BL.DTOS.Depatment;

namespace Lab2.BL.Manager.Departments
{
    public interface IDepartmentManager
    {
        DepartmentDto? GetById(int id);
    }
}
