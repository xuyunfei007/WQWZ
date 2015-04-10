using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using wqwz.Models;
using wqwz.Services;

namespace wqwz.Controllers
{
    public abstract class BaseController<TModel> : Controller where TModel:class
    { 
        public BaseService<TModel> Service { get; set; }
        public BaseController()
        {
            Service = new BaseService<TModel>();
        }

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
        private ActionResult AjaxAndCommonResult()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else
            {
                return View();
            }
        }
        private ActionResult AjaxAndCommonResult(TModel entity)
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView(entity);
            }
            else
            {
                return View(entity);
            }
        }


        public virtual ActionResult Add()
        {
            return AjaxAndCommonResult();
        }
        
        [HttpPost]
        public virtual ActionResult Add(TModel entity)
        {
            Service.Add(entity);
            return AjaxAndCommonResult();
        }
        public virtual ActionResult Find(int id)
        {
            return AjaxAndCommonResult(Service.Find(id));
        }
        [HttpPost]
        public virtual ActionResult Remove(TModel entity)
        {
            Service.Remove(entity);
            return AjaxAndCommonResult();
        }
        [HttpPost]
        public virtual ActionResult Update(TModel entity)
        {
            Service.Update(entity);
            return AjaxAndCommonResult();
        }
    }
}
