﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BobBookstore.Models
{
    public class CartItem
    {
        [Key]
        public long CartItem_Id { get; set; }
        public Price Price { get; set; }
        public Cart Cart { get; set; }
        public Book Book { get; set; }
    }
}
