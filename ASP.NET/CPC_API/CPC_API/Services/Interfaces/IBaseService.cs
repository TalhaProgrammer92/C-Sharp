using CPC_API.Models.Entities;

namespace CPC_API.Services.Interfaces
{
    public interface IBaseService<T>
    {
        public List<T> GetAll();
        public T? GetById(int id);
        public string Add(T entity);
        public string Update(T entity);
        public string Delete(int id);
    }
}
