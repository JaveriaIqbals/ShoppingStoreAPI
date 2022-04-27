using ShoppingStoreAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        //[ForeignKey("ProdId")]
        //public int ProdId { get; set; } = 0;

       
    }
}
