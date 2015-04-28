namespace wqwz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormField")]
    public partial class FormField
    {
        public FormField()
        {
            FormDatas = new HashSet<FormData>();
            FormFieldEnums = new HashSet<FormFieldEnum>();
        }

        public int Id { get; set; }

        public FormFieldType Type { get; set; }

        public int FormTemplateId { get; set; } 

        public string Regex { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual FormTemplate FormTemplate { get; set; } 

        public virtual ICollection<FormData> FormDatas { get; set; }

        public virtual ICollection<FormFieldEnum> FormFieldEnums { get; set; }

        public virtual ICollection<ELevel> ELevel { get; set; }
         
    }
}
