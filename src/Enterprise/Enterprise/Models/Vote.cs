using System;
using System.Collections.Generic;

#nullable disable

namespace Enterprise.Models
{
    public partial class Vote
    {
        public int WishId { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }

        public virtual User User { get; set; }
        public virtual User Wish { get; set; }
    }
}
