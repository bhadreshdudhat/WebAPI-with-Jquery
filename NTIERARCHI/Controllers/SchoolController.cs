using BLL;
using BLL.Domain;
using DAL;
using DAL.Repositories;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NTIERARCHI.Controllers
{
    //Install-Package Microsoft.AspNet.WebApi.Cors 
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SchoolController : ApiController
    {
        IUnitOfWork unitOfWork = new UnitOfWork(new FDB5331Context());

        // GET: api/School
        public IEnumerable<School> Get()
        {
            IEnumerable<School> schools = unitOfWork.Schools.GetAll();
            return schools;
        }

        // GET: api/School/5
        public School Get(string id)
        {
            //calling method from DAL
            School school = unitOfWork.Schools.GetTopSchool(id);
            return school;
        }

        //// api/School/5
        //public IEnumerable<string> Get(string id)
        //{
        //    IEnumerable<School> schools = unitOfWork.Schools.GetAll();
        //    return new string[] { "A", "B", "c" };
        //}

        // POST: api/School
        public void Post([FromBody]School school)
        {
            unitOfWork.Schools.Add(school);
            unitOfWork.Complete();
        }

        // PUT: api/School/5
        public void Put(string id, [FromBody]School school_update)
        {
            School school = unitOfWork.Schools.GetTopSchool(id);
            if (school != null)
            {
                unitOfWork.Schools.Update(school_update);
                unitOfWork.Complete();
            }
        }

        // DELETE: api/School/5
        public void Delete(string id)
        {
            School school = unitOfWork.Schools.GetTopSchool(id);
            unitOfWork.Schools.Remove(school);
            unitOfWork.Complete();
        }
    }
}
