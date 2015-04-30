using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wqwz.Models;

namespace wqwz.Controllers
{
    public partial class FormDataController : BaseController<FormData>
    {
        [HttpPost]
        [ValidateInput(false)]
        public virtual ActionResult AddArray(int[] FormFieldId, string[] PostData, int FormId, int[] FileIndex)
        {
            var guid = Guid.NewGuid();
            var formDatas = new List<FormData>();
            for (int i = 0; i < FormFieldId.Length; i++)
            {
                if (FileIndex != null && FileIndex.Contains(FormFieldId[i]))
                {
                    var fileGuid = Guid.NewGuid();
                    var index = FileIndex.ToList().IndexOf(FormFieldId[i]);
                    var dir = "/upLoad/" + fileGuid.ToString("N");
                    Request.Files[index].SaveAs(Server.MapPath(dir));
                    PostData[i] = Request.Files[index].FileName + fileGuid.ToString("N");

                }
                Service.Add(new FormData() { FormFieldId = FormFieldId[i], PostData = PostData[i], PostUserId = GetSessionUserId(), FormId = FormId, Guid = guid });
            }
            return Content("success");
        }
        [HttpGet]
        public virtual ActionResult _GetEdu(int id, bool isFilt)
        {
            var list = from data in Service.DbSet
                       where data.Form.FormTemplate.Id == id && data.FormField.IsShowInList
                       select data;
            if (isFilt)
            {
                list = list.Where(data => data.Form.UserId == GetSessionUserId());
            }
            if (list.Count() == 0)
            {
                return Content("不存在");
            }
            return PartialView(list.ToList());
        }


        public virtual ActionResult _GetEduInfo(Guid guid)
        {
            var list = from data in Service.DbSet
                       where data.Guid == guid
                       select data;
            return PartialView(list.ToList());
        }

        public ActionResult DelEdu(Guid guid)
        {

            try
            {
                var list = from data in Service.DbSet
                           where data.Guid == guid
                           select data;
                foreach (var item in list)
                {
                    Service.DbSet.Remove(item);
                }
                Service.SaveChanges();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Content("1");
        }


    }
}
