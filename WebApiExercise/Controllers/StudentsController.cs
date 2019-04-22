using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiExercise.Models;
using System.Web.Http.Cors;

namespace WebApiExercise.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StudentsController : ApiController
    {
        // GET: api/Students
        public IEnumerable<Student> Get()
        {
            return new List<Student>()
            {
                new Student{Id=1,Name="Student1Name",LastName="Student1LastName",Subjects=new List<string>{"Math","Biology","Literature"} },
                new Student{Id=2,Name="Student2Name",LastName="Student2LastName",Subjects=new List<string>{"Math","Biology","Literature"} },
                new Student{Id=3,Name="Student3Name",LastName="Student3LastName",Subjects=new List<string>{"Math","Biology","Literature"} },
                new Student{Id=4,Name="Student4Name",LastName="Student4LastName",Subjects=new List<string>{"Math","Biology","Literature"} },
                new Student{Id=5,Name="Student5Name",LastName="Student5LastName",Subjects=new List<string>{"Math","Biology","Literature"} }
            };
        }
    }

        // GET: api/Students/5
        //public Student Get (int id)
        //{
        //    return new List<Student>()
        //    {
        //        new Student{Id=1,Name="Student1Name",LastName="Student1LastName",Subjects=new List<string>{"Math","Biology","Literature"} },
        //        new Student{Id=2,Name="Student2Name",LastName="Student2LastName",Subjects=new List<string>{"Math","Biology","Literature"} },
        //        new Student{Id=3,Name="Student3Name",LastName="Student3LastName",Subjects=new List<string>{"Math","Biology","Literature"} },
        //        new Student{Id=4,Name="Student4Name",LastName="Student4LastName",Subjects=new List<string>{"Math","Biology","Literature"} },
        //        new Student{Id=5,Name="Student5Name",LastName="Student5LastName",Subjects=new List<string>{"Math","Biology","Literature"} }
        //    };
        //}

        
    
}
