
namespace wqwz.Models
{
    using System;
    using System.ComponentModel;
    
    public enum SexType : int
    {
        [Description("ÄÐ")]
        Male = 0,
        [Description("Å®")]
        Female = 1,
        [Description("±£ÃÜ")]
        Secert = 2
    }
}
