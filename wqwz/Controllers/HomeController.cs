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
        public virtual ActionResult Index()
        {
            var container = new wqwz.Models.wqwzContainer();
#if DEBUG
            //TODO 待删除的代码
            Session["UserID"] = 1;
            //var container = new wqwz.Models.wqwzContainer();
            //container.FormSet.Remove(container.FormSet.Find(1));
            //container.SaveChanges();
#endif
            return View();
        }

        public virtual ActionResult _NavBar()
        {
            return PartialView();
        }
        public void DeleteAllData()
        {
            var container = new wqwz.Models.wqwzContainer();
            foreach (var property in typeof(wqwzContainer).GetProperties().Where(property=>property.Name.EndsWith("Set")))
            {
                dynamic obj = property.GetValue(container, null); 
                obj.RemoveRange(obj); 
            }
            container.SaveChanges();
        }

        public virtual ActionResult AddTestData()
        {
            //TODO
            var container = new wqwz.Models.wqwzContainer();
            var user = new User() { Email = "123456@qq.com", Name = "john", Pwd = "123456", RegDate = DateTime.Now, Sex = SexType.Male };
            container.UserSet.Add(user);
            FormType type = null;
            for (int i = 0; i < 2; i++)
            {
                type = new FormType() { Name = "表单类型" + i.ToString() };
                container.FormTypeSet.Add(type);
            }
            container.SaveChanges();

            var formtpl = new FormTemplate() { Name="班级" };
            container.FormTemplateSet.Add(formtpl);
            container.SaveChanges();

            var form = new Form() { UserId = user.Id, Content = "什么什么什么", Status = StatusType.Unhandled, ReleaseDate = DateTime.Now, Title = "表单1", FormTypeId = type.Id, FormTemplateId = formtpl.Id};
            container.FormSet.Add(form);

            container.SaveChanges();
            var formfield = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.EnumSelect, Name = "班级" };
            var formfield2 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.Text, Name = "姓名" };
            container.FormFieldSet.Add(formfield);
            container.FormFieldSet.Add(formfield2);
            for (int i = 0; i < 3; i++)
            {
                var formfieldenum = new FormFieldEnum() { FormField = formfield, Name = i.ToString(), Value = i };
                container.FormFieldEnumSet.Add(formfieldenum);
            }
            container.SaveChanges();
            return Content(user.Id.ToString());
        }
    }
}
