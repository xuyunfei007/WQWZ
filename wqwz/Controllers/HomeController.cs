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

            var formtpl = new FormTemplate() { Name = "班级" };
            container.FormTemplateSet.Add(formtpl);
            container.SaveChanges();

            var form = new Form() { UserId = user.Id, Content = "什么什么什么", Status = StatusType.Unhandled, ReleaseDate = DateTime.Now, Title = "表单1", FormTypeId = type.Id, FormTemplateId = formtpl.Id };
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



        public virtual ActionResult Edu()
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
            var formtpl = new FormTemplate() { Name = "家教信息" };
            container.FormTemplateSet.Add(formtpl);
            container.SaveChanges();

            var form = new Form() { UserId = user.Id, Content = "什么什么什么",Status = StatusType.Unhandled, ReleaseDate = DateTime.Now, Title = "表单1", FormTypeId = type.Id, FormTemplateId = formtpl.Id };
            container.FormSet.Add(form);
            container.SaveChanges();
            var formfield1 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.EnumRadio,Name="身份",IsShowInList=true};
            var formfield2 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.Text, Name = "标题" ,IsShowInList=true};
            var formfield3 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.Text, Name = "教学" };
            var formfield4 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.Text, Name = "收费" };
            var formfield5 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.Text, Name = "教学时间" };
            var formfield6 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.ELevel , Name = "我的棋力" };
            var formfield7 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.ELevel , Name = "棋力" };
            var formfield8 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.TextArea, Name = "特点" };

            container.FormFieldSet.Add(formfield1);
            container.FormFieldSet.Add(formfield2);
            container.FormFieldSet.Add(formfield3);
            container.FormFieldSet.Add(formfield4);
            container.FormFieldSet.Add(formfield5);
            container.FormFieldSet.Add(formfield6);
            container.FormFieldSet.Add(formfield7);
            container.FormFieldSet.Add(formfield8);

            container.SaveChanges();

            var formfieldenum = new FormFieldEnum() { FormField = formfield1, Name = "老师", Value = 0 };
            var formfieldenum2 = new FormFieldEnum() { FormField = formfield1, Name = "学生", Value = 1 };
            container.FormFieldEnumSet.Add(formfieldenum);
            container.SaveChanges();
            container.FormFieldEnumSet.Add(formfieldenum2);
            container.SaveChanges();
            return Content(user.Id.ToString());
        }




        public virtual ActionResult AddRecruitTeacher()
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

            var formtpl = new FormTemplate() { Name = "招聘" };
            container.FormTemplateSet.Add(formtpl);
            container.SaveChanges();

            var form = new Form() { UserId = user.Id, Content = "什么什么什么", Status = StatusType.Unhandled, ReleaseDate = DateTime.Now, Title = "表单1", FormTypeId = type.Id, FormTemplateId = formtpl.Id };
            container.FormSet.Add(form);

            container.SaveChanges();
            var formfield = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.Text, Name = "标题" };
            var formfield2 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.Editor , Name = "招聘内容" };
            container.FormFieldSet.Add(formfield);
            container.FormFieldSet.Add(formfield2);
            container.SaveChanges();
            return Content(user.Id.ToString());
        }
        public virtual ActionResult AddRecruitStu()
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

            var formtpl = new FormTemplate() { Name = "招生"};
            container.FormTemplateSet.Add(formtpl);
            container.SaveChanges();

            var form = new Form() { UserId = user.Id, Content = "什么什么什么", Status = StatusType.Unhandled, ReleaseDate = DateTime.Now, Title = "表单1", FormTypeId = type.Id, FormTemplateId = formtpl.Id };
            container.FormSet.Add(form);

            container.SaveChanges();
            var formfield = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.Text, Name = "标题" };
            var formfield2 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.Editor, Name = "招生内容" };
            container.FormFieldSet.Add(formfield);
            container.FormFieldSet.Add(formfield2);
            container.SaveChanges();
            return Content(user.Id.ToString());
        }
        public virtual ActionResult PicUpload()
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

            var formtpl = new FormTemplate() { Name = "图片上传" };
            container.FormTemplateSet.Add(formtpl);
            container.SaveChanges();

            var form = new Form() { UserId = user.Id, Content = "什么什么什么", Status = StatusType.Unhandled, ReleaseDate = DateTime.Now, Title = "表单1", FormTypeId = type.Id, FormTemplateId = formtpl.Id };
            container.FormSet.Add(form);

            container.SaveChanges();
            var formfield = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.Text, Name = "标题"};
            var formfield2 = new FormField() { FormTemplateId = formtpl.Id, Type = FormFieldType.UploadPicture , Name = "选择图片" };
            container.FormFieldSet.Add(formfield);
            container.FormFieldSet.Add(formfield2);
      
            container.SaveChanges();
            return Content(user.Id.ToString());
        }
    }
}
