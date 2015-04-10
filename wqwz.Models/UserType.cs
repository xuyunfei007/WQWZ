
namespace wqwz.Models
{
    using System;
    using System.ComponentModel;
    
    [Flags]
    public enum UserType : int
    {
        [Description("��ͨ����Ա")]
        Admin = 0,
        [Description("��������Ա")]
        SuperAdmin = 1,
        [Description("��ͨ�û�")]
        User = 2,
        [Description("�߼��û�")]
        AdvanceUser = 3
    }
}
