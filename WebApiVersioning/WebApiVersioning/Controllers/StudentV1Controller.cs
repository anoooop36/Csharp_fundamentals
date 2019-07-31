using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiVersioning.Models;

namespace WebApiVersioning.Controllers
{
    public class StudentV1Controller : ApiController
    {
        List<StudentV1> students = new List<StudentV1>()
        {
            new StudentV1() {Id= 1, Name="Ajay"},
            new StudentV1() {Id = 2, Name="tom" },
            new StudentV1() {Id = 3, Name="Tony"},
        };

        [Route("api/v1/student")]
        public IEnumerable<StudentV1> Get()
        {
            return students;
        }

        [Route("api/v1/student/{id}")]
        public StudentV1 Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
