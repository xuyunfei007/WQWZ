namespace wqwz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormFieldEnum")]
    public partial class FormFieldEnum
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Value { get; set; }

        public int FormFieldId { get; set; }

        public virtual FormField FormField { get; set; }
    }
}
