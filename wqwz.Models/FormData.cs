namespace wqwz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormDataSet")]
    public partial class FormData
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int FormFieldId { get; set; }

        public int PostUserId { get; set; }

        public virtual FormField FormFields { get; set; }

        public virtual User PostUser { get; set; }
    }
}
