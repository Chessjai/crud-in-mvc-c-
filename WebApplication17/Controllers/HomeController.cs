using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Generator;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.FirstName = "Jaikumar";
            ViewBag.LastName = "YouTube Channel";
            ViewBag.Address = "Ariyalur";
            return View();
        }

        public ActionResult GetEmployee()
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee()
            {
                EmployeeID = 1,
                EmployeeName = "Mark Smith",
                Address = "London",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoan = true,
                Salary = 15000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now


            },
             new Employee()
             {
                 EmployeeID = 2,
                 EmployeeName = "Ram",
                 Address = "London",
                 DateOfJoining = System.DateTime.Now,
                 MartialStatus = 1,
                 IsEligibleForLoan = true,
                 Salary = 15000.00m,
                 CreatedBy = "Admin",
                 CreatedDate = System.DateTime.Now


             },
             new Employee()
             {
                 EmployeeID = 3,
                 EmployeeName = "Dunk",
                 Address = "London",
                 DateOfJoining = System.DateTime.Now,
                 MartialStatus = 1,
                 IsEligibleForLoan = true,
                 Salary = 15000.00m,
                 CreatedBy = "Admin",
                 CreatedDate = System.DateTime.Now


             },
              new Employee()
              {
                  EmployeeID = 4,
                  EmployeeName = "Krish",
                  Address = "London",
                  DateOfJoining = System.DateTime.Now,
                  MartialStatus = 1,
                  IsEligibleForLoan = true,
                  Salary = 15000.00m,
                  CreatedBy = "Admin",
                  CreatedDate = System.DateTime.Now


              },




    new Employee()
    {
        EmployeeID = 5,
        EmployeeName = "Irina",
        Address = "London",
        DateOfJoining = System.DateTime.Now,
        MartialStatus = 1,
        IsEligibleForLoan = true,
        Salary = 15000.00m,
        CreatedBy = "Admin",
        CreatedDate = System.DateTime.Now
    }
    };


            ViewBag.Employees = employees;
            return View();
        }
    }
}
