﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wqwz.Models;

namespace wqwz.Controllers
{
    public partial class FormFieldController : BaseController<FormField>
    {
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}
