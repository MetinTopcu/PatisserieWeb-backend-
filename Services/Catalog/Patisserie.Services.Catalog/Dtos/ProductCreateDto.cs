using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Patisserie.Services.Catalog.Models;
using System;

namespace Patisserie.Services.Catalog.Dtos
{
    public class ProductCreateDto
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Picture { get; set; }

        public string UserId { get; set; }

        public string CategoryId { get; set; }
    }
}
