using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wqwz.Helper
{
    public class Translate
    {
        public static MvcHtmlString tran(wqwz.Models.FormData formdata)
        {
            switch (formdata.FormField.Type)
            {
                case wqwz.Models.FormFieldType.Text:
                    break;
                case wqwz.Models.FormFieldType.Date:
                    break;
                case wqwz.Models.FormFieldType.Number:
                    break;
                case wqwz.Models.FormFieldType.Regex:
                    break;
                case wqwz.Models.FormFieldType.TextArea:
                    break;
                case wqwz.Models.FormFieldType.EnumRadio:
                    return new MvcHtmlString(formdata.FormField.FormFieldEnums.Where(e => e.Value.ToString() == formdata.PostData).First().Name);
                case wqwz.Models.FormFieldType.EnumCheck:
                    break;
                case wqwz.Models.FormFieldType.EnumSelect:
                    break;
                case wqwz.Models.FormFieldType.ELevel:
                    break;
                case wqwz.Models.FormFieldType.Editor:
                    break;
                case wqwz.Models.FormFieldType.UploadFile:
                    break;
                case wqwz.Models.FormFieldType.UploadPicture:
                    break;
                default:
                    break;
            }

            return new MvcHtmlString(formdata.PostData);


        }


    }
}