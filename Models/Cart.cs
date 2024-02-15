using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("ApplicationUser")]
        public int ApplicationUserID { get; set; }
        public List<CartProduct> Products { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
