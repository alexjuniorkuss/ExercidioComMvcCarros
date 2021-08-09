using AlunosMvc.Models;
using AlunosMvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlunosMvc.Controllers
{
    public class TeacherController : BaseController<Teacher, TeacherRepository>
    {
        public TeacherController():base(new TeacherRepository())
        {

        }
    }
}