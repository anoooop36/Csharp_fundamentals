using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApiAttributeRouting.Models;

namespace WebApiAttributeRouting.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        static List<Student> list = new List<Student>() {
            new Student{Name="pk", Id=1, Course="compiler" },
            new Student{Name="pk1", Id=2, Course="compiler1" },
            new Student{Name="pk2", Id=3, Course="compiler2" },
            new Student{Name="pk3", Id=4, Course="compiler3" },
        };

        [Route("")]
        public IHttpActionResult GetStudentsList()
        {
            return Ok(list);
        }

        [Route("{id:int:min(1)}", Name = "GetStudentById")]
        public IHttpActionResult GetStudentById(int id)
        {
            var student =  list.Where(s => s.Id == id);
            if (student == null)
                return NotFound();
            else
            {
                return Ok(student);
            }
        }

        [Route("{name:alpha}")]
        public Student GetStudentByName(string name)
        {
            return list.FirstOrDefault(s => s.Name == name);
        }

        [Route("{id}/course")]
        public string GetStudentCourses(int id)
        {
            if(list.Find(s => s.Id == id) != null)
                return list.Find(s => s.Id == id).Course;
            return "couldnt find id";
        }

        [Route("~/api/teachers")]
        public IEnumerable<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>() {
                new Teacher(){ Id=1, Name="Vineeth"},
                new Teacher(){ Id=2, Name="Vineeth1"},
                new Teacher(){ Id=3, Name="Vineeth2"},
            };
            return teachers;
        }

        [Route("")]
        public HttpResponseMessage Post([FromBody] Student student)
        {
            list.Add(student);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Url.Link("GetStudentById", new { id = student.Id}));
            return response;
        }
    }
}
