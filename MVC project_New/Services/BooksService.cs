using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MVC_project_New.Configuration;
using MVC_project_New.Interfaces;
using MVC_project_New.Models;

namespace MVC_project_New.Services
{
    public class BooksService : Ibooks
    {
        private readonly IMongoCollection<Book> _booksCollection;

        public BooksService(IOptions<BookStoreDatabaseSettings> bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                bookStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                bookStoreDatabaseSettings.Value.DatabaseName);

            _booksCollection = mongoDatabase.GetCollection<Book>(
                bookStoreDatabaseSettings.Value.BooksCollectionName);
        }

        public async Task Create(Book bookname) =>
        
            await _booksCollection.InsertOneAsync(bookname);
    

        public async Task delete(String id)=>
        
            await _booksCollection.DeleteOneAsync(x => x.Id == id);

        

        public async Task<List<Book>> Get()=>
        
            await _booksCollection.Find(_ => true).ToListAsync();
        

        public async Task<Book> GetById(String id)=>
        
            await _booksCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task<List<Book>> Sorting(String id)
        {
            var value = Builders<Book>.Filter.Where(x => x.BookName == id);
            var arnge = Builders<Book>.Sort.Ascending(x => x.Id);
            return await _booksCollection.Find(value).Sort(arnge).ToListAsync();
        }

        public async Task Update(String id, Book updatedBook)=>
            await _booksCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        public Task update(string id, Book updatedBook)
        {
            throw new NotImplementedException();
        }
    }
}
