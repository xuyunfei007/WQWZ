using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace wqwz.Models
{
    public enum UserStatusType : int
    {
        [Description("老师")]
        Teacher=0,
        [Description("学生")]
        Student=1,
        [Description("组织机构")]
        Organization=2
    }
}
