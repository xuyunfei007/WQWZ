namespace wqwz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("User")]
    public partial class User
    {
        public User()
        {
            FormDatas = new HashSet<FormData>();
            Forms = new HashSet<Form>();
            News = new HashSet<News>();
            RegDate = DateTime.Now;
        }

        [ReadOnly(true)]
        [HiddenInput(DisplayValue=false)] 
        public int Id { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Display(Name = "用户类型", Order = 5)] 
        public UserType Type { get; set; }

        [Required]
        [Display(Name = "用户名",Order=1)]
        [DataType(DataType.Text)]
        [StringLength(10,MinimumLength=3)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "邮箱", Order = 1)]
        [DataType(DataType.EmailAddress, ErrorMessage = "请输入正确的电子信箱")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "密码",Order=3)] 
        [DataType(DataType.Password)]
        public string Pwd { get; set; }

        [Display(Name="性别")]  
        [UIHint("Enum")]
        public SexType Sex { get; set; }

        [Display(Name = "身份")]
        [UIHint("Enum")]
        public UserStatusType Status { get; set; }

        [Display(Name = "公开个人资料")]
        public Boolean Public { get; set; }

        [Display(Name = "真实姓名")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 2)]
        public string RealName { get; set; }

        [Display(Name = "机构名")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 2)]
        public string OrganizationName { get; set; }

        [Display(Name = "电话")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(30, MinimumLength = 2)]
        public string PhoneNumber { get; set; }

        [Display(Name = "个人(机构)介绍")]
        [DataType(DataType.Html)]
        [UIHint("Summernote")]
        public string Info { get; set; }

        [ReadOnly(true)]
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "注册时间", Order = 4)] 
        public DateTime RegDate { get; set; }

        public virtual ICollection<FormData> FormDatas { get; set; }

        public virtual ICollection<Form> Forms { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
