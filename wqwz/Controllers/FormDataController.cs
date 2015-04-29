using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wqwz.Models;

namespace wqwz.Controllers
{
    public class FormDataController : BaseController<FormData>
    {
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddArray(int[] FormFieldId, string[] PostData, int FormId,int[] FileIndex)
        {
            var guid = Guid.NewGuid();
            var formDatas = new List<FormData>();
            for ( int i = 0; i < FormFieldId.Length; i++)
            {
                if ( FileIndex!=null&& FileIndex.Contains(FormFieldId[i]))
                {
                    var fileGuid = Guid.NewGuid();
                    var index=FileIndex.ToList().IndexOf(FormFieldId[i]);
                    var dir = "/upLoad/" + fileGuid.ToString("N");
                    Request.Files[index].SaveAs(Server.MapPath(dir));
                    PostData[i] = Request.Files[index].FileName + fileGuid.ToString("N");

                }
                Service.Add(new FormData() { FormFieldId = FormFieldId[i], PostData = PostData[i], PostUserId = GetSessionUserId(), FormId = FormId,Guid=guid});
            }
            return Content("success");
        }
        [HttpGet]
        public ActionResult Get(int id)
        {
            var list = from data in Service.DbSet
                       where data.FormId==id && data.FormField.IsShowInList
                       select data;
            return View(list.ToList());
        }

    }
}
