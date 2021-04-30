﻿using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject1.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetCategoryList()
        {
            var categoryvalues = categoryManager.GetAll();
            return View(categoryvalues);
        }
        //Sayfa yüklendiğinde açılır
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            categoryManager.Add(category);
            return RedirectToAction("GetCategoryList");
        }
    }
}