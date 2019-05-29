using BLL.Domain;
using BLL.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(FDB5331Context context)
            : base(context)
        {
        }

        public IEnumerable<Student> GetTopStudents(int count)
        {
            return FDB5331Context.Students.OrderByDescending(s => s.std_fname).Take(count).ToList();
        }


        public FDB5331Context FDB5331Context
        {

            get { return Context as FDB5331Context; }
        }
    }
}