using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlunosMvc.Models
{
    public class Teacher : BaseModel
    {
        public string Nome { get; set; }
        public string Diciplina { get; set; }
    }
}