using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class OnlineCourseController : ApiController
    {
        //[Authorize]
        [Route("api/courses")]
        [HttpPost]
        public IHttpActionResult GetCourses()
        {

            var courses = new List<OnlineCourse>();
            courses.Add(new OnlineCourse { Id = 1, Name = "Accounting Course", TrainingInstitiution = "FPD Accounting", Details = "Test 123" });
            courses.Add(new OnlineCourse { Id = 2, Name = "Medical Course", TrainingInstitiution = "FPD Medical", Details = "Test 456" });
            courses.Add(new OnlineCourse { Id = 3, Name = "Finacial Course", TrainingInstitiution = "FPD Financial", Details = "Test 789" });

            return Ok(courses.ToList());
        }
    }
}
