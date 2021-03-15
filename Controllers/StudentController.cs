using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using nguyenconghau_5951071025.Models;

namespace nguyenconghau_5951071025.Controllers
{
    public class StudentController : ApiController
    {
       
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            return StudentInfo.StudentInfList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return StudentInfo.StudentInfList[id];
        }
        

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
