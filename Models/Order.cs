using System.ComponentModel.DataAnnotations;

namespace Models
{
    public enum PaymentMethod
    {
        COD,
        ExternalPayment
    }
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
        public string ApplicationUserID { get; set; }
        public virtual List<Product>? Products { get; }
        public virtual List<OrderProduct>? OrderProducts { get; }
        public ApplicationUser ApplicationUser { get; set; }


    }
}