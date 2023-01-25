using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication17.Models;

namespace WebApplication17.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Subjects> Subjects { get; set; }
    }
}