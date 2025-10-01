namespace InventoryManagement.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        //Navigation Property
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
