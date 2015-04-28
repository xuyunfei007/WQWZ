namespace wqwz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("News")]
    public partial class News
    {
        public News()
        {
            ReleaseDate = DateTime.Now;
        }
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        [Display(Name = "���ű���")]
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 2)]
        [Display(Name = "��������")]
        [UIHint("Summernote")]
        public string Content { get; set; }

        public StatusType Status { get; set; }

        public int ReleaseUserId { get; set; }

        //public int NewsTypeId { get; set; }

        //public virtual NewsType NewsType { get; set; }

        public virtual User ReleaseUser { get; set; }
    }
}
