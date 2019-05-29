
using BLL.Domain;
using BLL.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Repositories
{
    public class SchoolRepository : Repository<School>, ISchoolRepository
    {
        public SchoolRepository(FDB5331Context context) : base(context)
        {
        }

        public School GetTopSchool(string id)
        {
            return FDB5331Context.Schools.FirstOrDefault(s => s.sch_code == id);

        }

        public IEnumerable<School> GetSchoolsWithAdvisors(int pageIndex, int pageSize = 10)
        {
            return FDB5331Context.Schools
                .Include(s => s.Advisors)
                .OrderBy(s => s.sch_name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }



        public FDB5331Context FDB5331Context
        {
            get { return Context as FDB5331Context; }
            //casting the context that we are inheriting from the generic repository
        }
    }
}