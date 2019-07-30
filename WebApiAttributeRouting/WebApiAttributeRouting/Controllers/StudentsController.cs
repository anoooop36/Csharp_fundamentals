using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAttributeRouting.Models;

namespace WebApiAttributeRouting.Controllers
{
    public class StudentsController : ApiController
    {
        static List<Student> list = new List<Student>() {
            new Student{Name="pk", Id=1, Course="compiler" },
            new Student{Name="pk1", Id=2, Course="compiler1" },
            new Student{Name="pk2", Id=3, Course="compiler2" },
            new Student{Name="pk3", Id=4, Course="compiler3" },
        };

        public IEnumerable<Student> GetStudentsList()
        {
            return list.ToList();
        }

        public IEnumerable<Student> GetStudentById(int id)
        {
            return list.Where(s => s.Id == id);
        }

        [Route("api/students/{id}/course")]
        public string GetStudentCourses(int id)
        {
            if(list.Find(s => s.Id == id) != null)
                return list.Find(s => s.Id == id).Course;
            return "couldnt find id";
        }
    }
}
