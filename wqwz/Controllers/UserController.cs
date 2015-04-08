using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wqwz.Models;

namespace wqwz.Controllers
{
    public class UserController : BaseController<User>
    {
        public wqwz.Services.BaseService<User> UserService { get; set; }

        public UserController()
        {
            UserService = new Services.BaseService<User>();
        }

        public override ActionResult Add(User entity)
        {
            entity.RegDate = DateTime.Now;
            entity.Type = UserType.User;
            UserService.Add(entity);
            return View("Success");
        }

        public ActionResult _Login()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult _Login(User entity)
        {
            var user = UserService.DbSet.Where(m => m.Pwd == entity.Pwd && (entity.Name == m.Name || entity.Email == m.Email));
            if (user.Count()==1)
            {
                //成功
                SetSessionUser(user.ToList()[0].Id);
                return PartialView("Success");
            }
            else
            {
                //密码或用户名错误
                Response.StatusCode = 403;
                return Content("用户名或密码错误");
                return View(entity);
            }
        }
    }
}
