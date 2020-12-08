using System;
using System.Collections.Generic;

#nullable disable

namespace Enterprise.Models
{
    public partial class Wish
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        public virtual User IdNavigation { get; set; }
    }
}
