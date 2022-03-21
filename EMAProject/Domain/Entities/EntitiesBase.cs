using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMAProject.Domain.Entities
{
    public abstract class EntitiesBase
    {
        protected EntitiesBase() => DateAdded = DataType.DateTime;
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        [Display(Name = "SubTitle")]
        public virtual string SubTitle { get; set; }
        
        [Display(Name = "Text(Description)")]
        public virtual string Text { get; set; }
        
        [Display(Name = "FloatNumber(Price)")]
        public virtual string Price { get; set; }

        
        [Display(Name = "Title image")]
        public virtual string TitleImagePath { get; set; }
        
        [DataType(DataType.DateTime)]
        public DataType DateAdded { get; set; }
    }
}
