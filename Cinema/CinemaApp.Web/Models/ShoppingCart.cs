﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApp.Web.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }
        public virtual ICollection<TicketModel> TicketsInShoppingCart { get; set; }
    }
}
