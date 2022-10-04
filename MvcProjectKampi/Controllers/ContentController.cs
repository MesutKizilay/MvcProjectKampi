﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }

        Context c = new Context();
        public ActionResult GetAllContent()
        {
            var values=
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentValues=cm.GetListByHeadingID(id);
            return View(contentValues);
        }
    }
}