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
        public ActionResult AddArray(int[] FormFieldId, string[] PostData, int FormId)
        {
            var formDatas = new List<FormData>();
            for (int i = 0; i < FormFieldId.Length; i++)
            {
                Service.Add(new FormData() { FormFieldId = FormFieldId[i], PostData = PostData[i], PostUserId = GetSessionUserId(), FormId = FormId });
            }
            return Content("success");
        }
    }
}
