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
        [Display(Name = "�û�����", Order = 5)] 
        public UserType Type { get; set; }

        [Required]
        [Display(Name = "�û���",Order=1)]
        [DataType(DataType.Text)]
        [StringLength(10,MinimumLength=3)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "����", Order = 1)]
        [DataType(DataType.EmailAddress, ErrorMessage = "��������ȷ�ĵ�������")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "����",Order=3)] 
        [DataType(DataType.Password)]
        public string Pwd { get; set; }

        [Display(Name="�Ա�")]  
        [UIHint("Enum")]
        public SexType Sex { get; set; }

        [Display(Name = "���")]
        [UIHint("Enum")]
        public UserStatusType Status { get; set; }

        [Display(Name = "������������")]
        public Boolean Public { get; set; }

        [Display(Name = "��ʵ����")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 2)]
        public string RealName { get; set; }

        [Display(Name = "������")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 2)]
        public string OrganizationName { get; set; }

        [Display(Name = "�绰")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(30, MinimumLength = 2)]
        public string PhoneNumber { get; set; }

        [Display(Name = "����(����)����")]
        [DataType(DataType.Html)]
        [UIHint("Summernote")]
        public string Info { get; set; }

        [ReadOnly(true)]
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "ע��ʱ��", Order = 4)] 
        public DateTime RegDate { get; set; }

        public virtual ICollection<FormData> FormDatas { get; set; }

        public virtual ICollection<Form> Forms { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
