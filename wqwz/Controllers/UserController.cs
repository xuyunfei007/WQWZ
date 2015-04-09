using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wqwz.Models;

namespace wqwz.Controllers
{
    public partial class UserController : BaseController<User>
    { 
        public override ActionResult Add(User entity)
        {
            entity.RegDate = DateTime.Now;
            entity.Type = UserType.User;
            Service.Add(entity);
            return Content("添加成功");
        }

        public virtual ActionResult _Login()
        {
            return PartialView();
        }

        [HttpPost]
        public virtual ActionResult _Login(User entity)
        {
            var user = Service.DbSet.Where(m => m.Pwd == entity.Pwd && (entity.Name == m.Name || entity.Email == m.Email));
            if (user.Count()==1)
            {
                //成功
                SetSessionUser(user.ToList()[0].Id);
                return Content("Success");
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
