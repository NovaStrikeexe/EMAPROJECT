using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EMAProject.Domain.Entities
{
    public class ServiceItem:EntitiesBase
    {
        [Required(ErrorMessage ="Enter name of Service Item")]
        [Display(Name ="Name of Service Item")]
        public override string Title { get; set; }

        [Display(Name = "Brief description of the service")]
        public override string SubTitle { get; set; }

        [Display(Name = "Description of the service")]
        public override string Text { get; set; }

    }
}
