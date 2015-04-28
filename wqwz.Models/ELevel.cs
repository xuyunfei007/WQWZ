using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace wqwz.Models
{
    public enum ELevel : int
    {
        [Description("无段")]
        Level0 = 0,
        [Description("业余初段")]
        Level1 = 1,
        [Description("业余2段")]
        Level2 = 2,
        [Description("业余3段")]
        Level3 = 3,
        [Description("业余4段")]
        Level4 = 4,
        [Description("业余5段")]
        Level5 = 5,
        [Description("业余6段")]
        Level6 = 6,
        [Description("业余7段")]
        Level7 = 7,
        [Description("业余8段")]
        Level8 = 8,
        [Description("职业初段")]
        Level9 = 9,
        [Description("职业二段")]
        Level10 = 10,
        [Description("职业三段")]
        Level11 = 11,
        [Description("职业四段")]
        Level12 = 12,
        [Description("职业五段")]
        Level13 = 13,
        [Description("职业六段")]
        Level14 = 14,
        [Description("职业七段")]
        Level15 = 15,
        [Description("职业八段")]
        Level16 = 16,
        [Description("职业九段")]
        Level17 = 17
    }
}
