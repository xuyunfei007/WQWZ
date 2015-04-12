namespace wqwz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewsType")]
    public partial class NewsType
    {
        public NewsType()
        {
            News = new HashSet<News>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
