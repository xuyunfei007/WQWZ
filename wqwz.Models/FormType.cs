namespace wqwz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormType")]
    public partial class FormType
    {
        public FormType()
        {
            Forms = new HashSet<Form>();
        }

        public int Id { get; set; }

        [Required]
        [Display(Name="Ãû×Ö")]
        [StringLength(20,MinimumLength=1)]
        public string Name { get; set; }
        
        public virtual ICollection<Form> Forms { get; set; }
    }
}
