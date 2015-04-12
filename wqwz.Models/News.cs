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
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Content { get; set; }

        public StatusType Status { get; set; }

        public int ReleaseUserId { get; set; }

        public int NewsTypeId { get; set; }

        public virtual NewsType NewsType { get; set; }

        public virtual User ReleaseUser { get; set; }
    }
}
