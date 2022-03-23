using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EMAProject.Domain.Entities
{
    public abstract class EntitiesBase
    {
        protected EntitiesBase() => DateAdded = DataType.DateTime;
        [BsonRequired]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        public virtual string Title { get; set; }

        [BsonElement( "SubTitle")]
        public virtual string SubTitle { get; set; }
        
        [BsonElement( "Text(Description)")]
        public virtual string Text { get; set; }
        
        [BsonElement( "FloatNumber(Price)")]
        public virtual string Price { get; set; }

        
        [BsonElement( "Title image")]
        public virtual string TitleImagePath { get; set; }
        
        [BsonElement("DateAdded")]
        public DataType DateAdded { get; set; }
    }
}
