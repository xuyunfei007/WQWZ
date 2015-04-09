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

        public FormController()
        { 
            FormTypeervice = new Services.BaseService<FormType>();
        } 
        public override ActionResult Add(Form entity)
        {
            return base.Add(entity);
        }
    }
}
