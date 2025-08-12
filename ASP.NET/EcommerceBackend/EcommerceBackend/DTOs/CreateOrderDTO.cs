using System.ComponentModel.DataAnnotations;

namespace EcommerceBackend.DTOs
{
    public class CreateOrderDTO
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string ShippingPhone { get; set; }
        public string ShippingAddress { get; set; }

        [Required]
        public List<OrderItemDTO> Items { get; set; };
        public decimal Subtotal { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal Total { get; set; }
    }

    public class OrderItemDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}