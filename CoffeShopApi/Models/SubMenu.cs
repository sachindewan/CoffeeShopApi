﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShopApi.Models
{
    public class SubMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

    }
}
