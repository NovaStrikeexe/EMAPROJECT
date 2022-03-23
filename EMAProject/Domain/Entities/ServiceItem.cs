using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EMAProject.Domain.Entities
{
    public class ServiceItem:EntitiesBase
    {
        
        [BsonRequired]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonRequired]
        [BsonElement("Name")]
        public override string Title { get; set; }

        [BsonElement("Brief description")]
        public override string SubTitle { get; set; }

        [BsonElement("Description")]
        public override string Text { get; set; }

        
        [BsonElement("Price")]
        public override string Price { get; set; }

    }
}
