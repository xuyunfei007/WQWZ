﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wqwz.Models;

namespace wqwz.Controllers
{
    public partial class FormFieldEnumController : BaseController<FormFieldEnum>
    { 
        public override ActionResult Add(FormFieldEnum entity)
        {
            return base.Add(entity);
        }
    }
}
