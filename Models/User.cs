using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace TheWall.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "First name must be atleast 2 characters long.")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Last name must be atleast 2 characters.")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password must be atleast 8 characters")]
        public string Password { get; set; }
        [NotMapped]
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        //public ShoppingCart shoppingCart { get; set; }
        //public List<Order> ListOfOrders { get; set; }
        //[ForeignKey("ProductId")]
        //public List<Product> ProductInventory { get; set; }

        public string ShoppingCart { get; set; }

        //public List<Product> demoShoppingCart { get; set; }

    }
}
