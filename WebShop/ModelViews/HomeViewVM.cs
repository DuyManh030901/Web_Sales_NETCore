using System;
using System.Collections.Generic;
using WebShop.Models;

namespace WebShop.ModelViews
{
    public class HomeViewVM
    {
        public List<Post> TinTucs { get; set; }
        public List<ProductHomeVM> Products { get; set; }
        public QuangCao quangcao { get; set; }
    }
}
