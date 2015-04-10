namespace wqwz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserSet")]
    public partial class User
    {
        public User()
        {
            FormDatas = new HashSet<FormData>();
            Forms = new HashSet<Form>();
            News = new HashSet<News>();
        }

        public int Id { get; set; }

        public UserType Type { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Pwd { get; set; }

        public SexType Sex { get; set; }

        public DateTime RegDate { get; set; }

        [Required]
        public string Email { get; set; }

        public virtual ICollection<FormData> FormDatas { get; set; }

        public virtual ICollection<Form> Forms { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
