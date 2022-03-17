using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace EMAProject.Domain.Entities
{
    public class TextField : EntitiesBase
    {
        [Required]
        public string CodeWord { get; set; }
        [Display(Name = "Name of Page (Title)")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Description of the service")]
        public override string Text { get; set; } = "Content is filled by the administrator";

    }
}
