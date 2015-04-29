using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace wqwz.Models
{
    [Table("FormTemplate")]
    public class FormTemplate
    {
        public FormTemplate()
        {
            Forms = new HashSet<Form>();
            FormFields = new HashSet<FormField>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Type { get; set; }
        public virtual ICollection<FormField> FormFields { get; set; }
        public virtual ICollection<Form> Forms { get; set; }


    }
}
