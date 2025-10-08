using InventoryManagement.Models.Entities;

namespace InventoryManagement.Services.Interfaces
{
    public interface IItem
    {
        public List<Item> GetAll();
        public string Add(Item item);
        public string Delete(Item item);
        public string Update(Item item);
    }
}
