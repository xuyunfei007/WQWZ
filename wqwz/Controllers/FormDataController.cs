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
            var formDatas = new List<FormData>();
            for ( int i = 0; i < FormFieldId.Length; i++)
            {
                if (FileIndex.Contains(FormFieldId[i]))
                {
                    var guid = Guid.NewGuid();
                    var index=FileIndex.ToList().IndexOf(FormFieldId[i]);
                    var dir="/upLoad/"+guid.ToString("N");
                    Request.Files[index].SaveAs(Server.MapPath(dir));
                    PostData[i] = Request.Files[index].FileName + guid.ToString("N");

                }
                Service.Add(new FormData() { FormFieldId = FormFieldId[i], PostData = PostData[i], PostUserId = GetSessionUserId(), FormId = FormId });
            }
            return Content("success");
        }
    }
}
