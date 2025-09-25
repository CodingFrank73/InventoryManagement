using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0, int.MaxValue, ErrorMessage ="Wert darf nicht kleiner 0 sein.")]
        public int Stock { get; set; }
    }
}
