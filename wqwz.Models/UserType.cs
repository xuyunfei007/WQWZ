
namespace wqwz.Models
{
    using System;
    
    [Flags]
    public enum UserType : int
    {
        Admin = 0,
        SuperAdmin = 1,
        User = 2,
        AdvanceUser = 3
    }
}
