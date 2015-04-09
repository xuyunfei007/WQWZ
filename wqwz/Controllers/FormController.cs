using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wqwz.Models;

namespace wqwz.Controllers
{
    public class FormController : BaseController<Form>
    {
        public wqwz.Services.BaseService<Form> FormService { get; set; }

        public FormController()
        {
            FormService = new Services.BaseService<Form>();
        }

        public override ActionResult Add(Form entity)
        {
            return base.Add(entity);
        }

    }
}
