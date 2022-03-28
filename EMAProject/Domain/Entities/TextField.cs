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
    public class TextField : EntitiesBase
    {
      [BsonRequired]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonRequired]
        [BsonElement( "CodeWord")]
        [JsonProperty("CodeWord")]        
        public string CodeWord { get; set; }

        [BsonElement( "Name of Page (Title)")]
        [JsonProperty("Name of Page (Title)")] 
        public override string Title { get; set; } = "Information page";

        [BsonElement( "Description of the service")]
        [JsonProperty("Description of the service")] 
        public override string Text { get; set; } = "Content is filled by the administrator";

    }
}
