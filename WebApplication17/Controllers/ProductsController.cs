using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class ProductsController : Controller
    {
        Productdata db = new Productdata();
        public ViewResult Index()

        {
            return View(db.ProductsList.ToList());
        }
        public ViewResult Details(int id)
        {
            Product1 product = db.ProductsList.Single(x => x.ProductId == id);
            return View(product);
        }

    }
}