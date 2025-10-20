using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Context
{
    public class CatalogContext : ICatalogContext
    {
        public IMongoCollection<Product> Products { get; }
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("ConnectionSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("ConnectionSettings:DatabaseName"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("ConnectionSettings:CollectionName"));
            //CatalogContextSeed.SeedData(Products);
        }
    }
}
