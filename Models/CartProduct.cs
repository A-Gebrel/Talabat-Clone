﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CartProduct
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product {  get; set; }
    }
}
