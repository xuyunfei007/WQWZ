namespace wqwz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormData")]
    public partial class FormData
    {
        public FormData()
        {
            PostDate = DateTime.Now;
        }
        public int Id { get; set; }

        public DateTime PostDate { get; set; }

        public int FormFieldId { get; set; }

        public int PostUserId { get; set; }

        public string PostData { get; set; }
        public int FormId { get; set; }

        public virtual FormField FormFields { get; set; }

        public virtual User PostUser { get; set; }

        public virtual Form Form { get; set; }
    }
}
