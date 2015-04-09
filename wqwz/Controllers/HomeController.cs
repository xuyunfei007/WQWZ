using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wqwz.Models;

namespace wqwz.Controllers
{
    public partial class HomeController : Controller
    {
        //
        // GET: /Home/

        public virtual ActionResult Index()
        {
            var container = new wqwz.Models.wqwzContainer();
            var user = container.UserSet.Find(1);
            return View();
        }

        public virtual ActionResult _NavBar()
        {
            return PartialView();
        }
        public virtual ActionResult AddTestData()
        {
            var container = new wqwz.Models.wqwzContainer();
            var user = new User() {  Email="123456@qq.com",Name="张三",Pwd="123456",RegDate = DateTime.Now, Sex= SexType.Male};
            var userid = container.UserSet.Add(user).Id;
            for (int i = 0; i < 2; i++)
            {
                var type = new FormType() { Name = "表单类型"+i.ToString() };
                container.FormTypeSet.Add(type);
            } 
            var form = new Form() {  UserId = userid,Content="",Pass=true,ReleaseDate = DateTime.Now,Title = "表单1", FormTypeId = 1 };
            container.FormSet.Add(form);
            container.SaveChanges();  
            var formfield = new FormField() { FormId = 1, Type = FormFieldType.Text };
            var formfield2 = new FormField() { FormId = 1, Type = FormFieldType.EnumSelect }; 
            container.FormFieldSet.Add(formfield);
            var enumformfieldid = container.FormFieldSet.Add(formfield2);
            for (int i = 0; i < 3; i++)
            {
                var formfieldenum = new FormFieldEnum() { FormField = enumformfieldid, Name = i.ToString(),Value = i };
                container.FormFieldEnumSet.Add(formfieldenum);
            }
            container.SaveChanges(); 
            return Content("1"); 
        }
    }
}
