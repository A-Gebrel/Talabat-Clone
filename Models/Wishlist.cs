using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Wishlist
    {
        public int ID { get; set; }
        public string ApplicationUserID { get; set; }

        public List<WishedItem> WishedProducts { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
