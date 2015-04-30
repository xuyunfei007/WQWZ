using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wqwz.Models;

namespace wqwz.Controllers
{
    public partial class FormController : BaseController<Form>
    {  
        public wqwz.Services.BaseService<FormType> FormTypeervice { get; set; }

        public wqwz.Services.BaseService<FormData> FormDataService { get; set; }
        public FormController()
        { 
            FormTypeervice = new Services.BaseService<FormType>();
            FormDataService = new Services.BaseService<FormData>();
        } 
        public override ActionResult Add(Form entity)
        {
            return base.Add(entity);
        }
        public override ActionResult Find(int id)
        {
           
            if ( Request["guid"]!=null)

            {
                var guid=Guid.Parse(Request["guid"]);
                var list = from data in FormDataService.DbSet
                           where data.Guid == guid
                           select data;
                ViewBag.Data = list.ToList();
            }
            //else
            //{
                return base.Find(id);
            //}
            
        }
    }
}
