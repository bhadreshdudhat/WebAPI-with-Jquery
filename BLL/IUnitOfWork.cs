using BLL.Repositories;
using System;

namespace BLL
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        ISchoolRepository Schools { get; }
        // IRepository<User> UserRepository { get; }
        int Complete();
    }
}
