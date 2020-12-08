using System;
using System.Collections.Generic;

#nullable disable

namespace Enterprise.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string PasswordHash { get; set; }

        public virtual Wish Wish { get; set; }
    }
}
