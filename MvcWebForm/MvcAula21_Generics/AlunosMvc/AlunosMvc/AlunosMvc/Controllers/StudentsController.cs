using AlunosMvc.Models;
using AlunosMvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlunosMvc.Controllers
{
    public class StudentsController : BaseController<Student, StudentRepository>
    {
        public StudentsController():base(new StudentRepository())
        {

        }
    }   
}