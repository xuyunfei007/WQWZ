using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using wqwz.Models;
using wqwz.Services;

namespace wqwz.Controllers
{
    public abstract class BaseController<TModel> : Controller
    {
        internal void SetSessionUser(int ID)
        {
            Session["UserID"] = ID;
        }
        internal User GetSessionUser()
        {
            if (Session["UserID"]==null)
	        {
		         return null;
	        }
            var ID = (int)Session["UserID"];
            var service = new BaseService<User>();
            return service.Find(ID);
        }

        public virtual ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public virtual ActionResult Add(TModel entity)
        {
            return View();
        }
        public virtual ActionResult Find()
        {
            return View();
        }
        [HttpPost]
        public virtual ActionResult Remove(TModel entity)
        {
            return View();
        }
        [HttpPost]
        public virtual ActionResult Update(TModel entity)
        {
            return View();
        }
    }
}
