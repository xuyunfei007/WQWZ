namespace wqwz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormSet")]
    public partial class Form
    {
        public Form()
        {
            FormFields = new HashSet<FormField>();
            ReleaseDate = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public StatusType Status { get; set; }

        [Required]
        public string Content { get; set; }

        public int UserId { get; set; }

        public int FormTypeId { get; set; }

        public virtual ICollection<FormField> FormFields { get; set; }

        public virtual FormType FormType { get; set; }

        public virtual User ReleaseUser { get; set; }
    }
}
