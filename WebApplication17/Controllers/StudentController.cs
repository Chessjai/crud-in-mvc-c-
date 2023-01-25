
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using WebApplication17.Models;
using WebApplication17.ViewModels;

namespace WebApplication17.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetStudents()
        {
            var students = new Student() { Id = 1, Name = "Jai", Address = "Ariyalur" };
            var subjects = new List<Subjects>()

            {
                new Subjects(){Id=1,Name="Computer Programming"},
                new Subjects(){Id=2,Name="Database Analysis"},
                new Subjects(){Id=3,Name="Fundamental Of Algorithm"},

            };
            var viewmodel = new StudentViewModel()
            {
                Student = students,
                Subjects = subjects
            };

            return View(viewmodel);
            



        }
        public ActionResult ByPassingYear(int month,int year)
        {
            return Content("Month:" + month + "Year:" + year);
        }
    }
}