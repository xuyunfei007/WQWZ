
namespace wqwz.Models
{
    using System;
    using System.ComponentModel;
    
    public enum SexType : int
    {
        [Description("��")]
        Male = 0,
        [Description("Ů")]
        Female = 1,
        [Description("����")]
        Secert = 2
    }
}
