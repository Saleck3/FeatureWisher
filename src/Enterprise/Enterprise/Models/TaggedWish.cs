using System;
using System.Collections.Generic;

#nullable disable

namespace Enterprise.Models
{
    public partial class TaggedWish
    {
        public int WishId { get; set; }
        public int TagId { get; set; }

        public virtual Tag Tag { get; set; }
        public virtual Wish TagNavigation { get; set; }
    }
}
