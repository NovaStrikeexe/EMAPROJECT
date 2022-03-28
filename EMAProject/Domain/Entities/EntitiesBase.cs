using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EMAProject.Domain.Entities
{
    public abstract class EntitiesBase
    {
        [BsonRequired]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        [JsonProperty("Title")]
        public virtual string Title { get; set; }

        [BsonElement( "SubTitle")]
        [JsonProperty("SubTitle")]
        public virtual string SubTitle { get; set; }
        
        [BsonElement( "Text(Description)")]
        [JsonProperty("Text(Description)")]
        public virtual string Text { get; set; }
        
        [BsonElement( "FloatNumber(Price)")]
        [JsonProperty( "FloatNumber(Price)")]
        public virtual string Price { get; set; }

        
        [BsonElement( "Title image")]
        [JsonProperty( "Title image")]
        public virtual string TitleImagePath { get; set; }
        
        [BsonElement("DateAdded")]
        [JsonProperty("DateAdded")]
        public DateTime DateAdded { get; set; }
    }
}
