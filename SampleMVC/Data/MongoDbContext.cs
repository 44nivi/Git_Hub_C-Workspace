using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SampleMVC.Configuration;
using SampleMVC.Models;

namespace SampleMVC.Data
{
    public class MongoDbContext
    {
            private readonly IMongoDatabase _database;

            public MongoDbContext(IOptions<MongoDbConfiguration> settings)
            {
                var client = new MongoClient(settings.Value.ConnectionString);
                _database = client.GetDatabase(settings.Value.DatabaseName);
            }

            public IMongoCollection<CSharpCornerArticle> CSharpCornerArticles =>
                _database.GetCollection<CSharpCornerArticle>("CSharpCornerArticles");
    }
}
