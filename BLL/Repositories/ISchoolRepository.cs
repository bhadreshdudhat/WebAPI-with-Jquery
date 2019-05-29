
using BLL.Domain;
using System.Collections.Generic;

namespace BLL.Repositories
{
    public interface ISchoolRepository : IRepository<School>
    {
        School GetTopSchool(string id);
        IEnumerable<School> GetSchoolsWithAdvisors(int pageIndex, int pageSize);
    }
}