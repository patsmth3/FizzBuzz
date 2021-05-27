using System.Collections.Generic;

namespace Dapr
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments(); //Stubbed out method

    }
}