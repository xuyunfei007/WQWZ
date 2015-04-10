
namespace wqwz.Models
{
    using System;
    using System.ComponentModel;
    
    [Flags]
    public enum UserType : int
    {
        [Description("普通管理员")]
        Admin = 0,
        [Description("超级管理员")]
        SuperAdmin = 1,
        [Description("普通用户")]
        User = 2,
        [Description("高级用户")]
        AdvanceUser = 3
    }
}
