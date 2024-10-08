﻿using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Strategy.Models
{
    public class Product
    {
        [BsonId] //For MongoDB
        [Key] //For EFCore
        [BsonRepresentation(BsonType.ObjectId)] //For MongoDB
        [BsonElement("_id")]
        public string? Id { get; set; }

        public string Name { get; set; }

        [BsonRepresentation(BsonType.Decimal128)] //For MongoDB
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string? UserId { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedDate { get; set; }
    }
}
