using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlunosMvc.Models
{
    public class Student : BaseModel
    {
        public string Name { get; set; }
        public string Classe { get; set; }
        [Display(Name = "Idade")]
        public int Age { get; set; }
    }
}