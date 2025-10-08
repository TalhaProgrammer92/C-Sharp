using InventoryManagement.Models;
using InventoryManagement.Models.Entities;
using InventoryManagement.Services.Interfaces;

namespace InventoryManagement.Services
{
    public class ItemService : IItem
    {
        readonly Models.Context.Item context;

        public ItemService(Models.Context.Item context)
        {
            this.context = context;
        }

        public string Add(Item item)
        {
            context.Items.Add(item);
            context.SaveChanges();
            return "Item has been added successfully!";
        }

        public string Delete(Item item)
        {
            var selectedItem = context.Items.Find(item.Id);

            if (selectedItem is null)
                return "Item not Found!";

            context.Items.Remove(selectedItem);
            context.SaveChanges();
            return "Item has been removed successfully!";
        }

        public List<Item> GetAll()
        {
            return context.Items.ToList();
        }

        public string Update(Item item)
        {
            var selectedItem = context.Items.Find(item.Id);

            if (selectedItem is null)
                return "Item not Found!";

            selectedItem.Name = item.Name;
            selectedItem.Price = item.Price;
            selectedItem.CompanyName = item.CompanyName;
            selectedItem.Description = item.Description;

            context.SaveChanges();
            return "Item has been updated successfully!";
        }
    }
}
