using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum Gender
    {
        Male,
        Female
    }


    public class ApplicationUser: IdentityUser
    {
        //[Key]
        //public int ID { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string ContactNo {  get; set; }
        public string Address { get; set; }
        
        public int CartID {  get; set; }
        public virtual Cart? Cart {  get; set; }

        //public virtual List<Order>? Orders { get; set; }
        //public virtual List<Product>? Wishlist { get; set; }

    }
}
