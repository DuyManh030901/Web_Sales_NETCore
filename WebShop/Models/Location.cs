﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebShop.Models
{
    public partial class Location
    {
        public Location()
        {
            Customers = new HashSet<Customer>();
        }

        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Slug { get; set; }
        public string NamewithType { get; set; }
        public string PathwithType { get; set; }
        public int? ParentCode { get; set; }
        public int? Levels { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
