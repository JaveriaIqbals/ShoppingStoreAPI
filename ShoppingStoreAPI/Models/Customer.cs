using System.ComponentModel.DataAnnotations;

namespace ShoppingStoreAPI
{
    public class Customer
    {
        [Key]
        public int CustId { get; set; }

        [Required]
        public string CustName { get; set; } = "";
        
        public string? CustAddress { get; set; }

        [Required]
        public string CustContact { get; set; } = "";

        public int ProdId { get; set; } = 0;

    }
}
