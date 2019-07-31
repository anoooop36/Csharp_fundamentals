using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiVersioning.Models;

namespace WebApiVersioning.Controllers
{
    public class StudentV2Controller : ApiController
    {
        List<StudentV2> students = new List<StudentV2>()
        {
            new StudentV2() {Id = 3, Name="Tony"},
            new StudentV2() {Id= 1, Name="Ajay"},
            new StudentV2() {Id = 2, Name="tom" },
        };

        public IEnumerable<StudentV2> Get()
        {
            return students;
        }

        public StudentV2 Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
