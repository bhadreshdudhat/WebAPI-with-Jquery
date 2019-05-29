
using BLL.Domain;
using System.Collections.Generic;

namespace BLL.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Student> GetTopStudents(int count);
    }
}