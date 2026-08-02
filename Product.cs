using System.ComponentModel.DataAnnotations;

namespace _27Assignment.Module
{
    public class Product
    {
        [Required(ErrorMessage = "product id is required")]
        public int ProductId {  get; set; }

        [Required(ErrorMessage = "product Name is required")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "product Price is required")]


        public int ProductPrice { get; set; }
        [Required(ErrorMessage = "product category is required")]

        public string ProductCategory { get; set; }

    }
}
