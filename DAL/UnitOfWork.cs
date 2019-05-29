using BLL;
using BLL.Repositories;
using DAL.Repositories;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FDB5331Context _context;


        public ISchoolRepository Schools { get; private set; }
        public IStudentRepository Students { get; private set; }
        //private IRepository<User> _userRepository{ get; private set; };

        public UnitOfWork(FDB5331Context context)
        {
            _context = context;
            Schools = new SchoolRepository(_context);
            Students = new StudentRepository(_context);
            //_userRepository = new UserRepository(_context);
        }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        //from IDisposable interface
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
