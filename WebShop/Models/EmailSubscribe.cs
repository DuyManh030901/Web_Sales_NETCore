using System;
using System.Collections.Generic;

#nullable disable

namespace WebShop.Models
{
    public partial class EmailSubscribe
    {
        public int EmailSubscribeId { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
