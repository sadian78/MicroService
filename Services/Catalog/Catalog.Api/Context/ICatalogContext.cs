using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Context
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
