using MVC_project_New.Models;

namespace MVC_project_New.Interfaces
{
    public interface Ibooks
    {
        public Task <List<Book>> Get();
        public Task<Book> GetById(String id);
        public Task Create(Book bookname);
        public Task  update(String id,Book updatedBook);
        public Task  delete(String id);

    }
}
