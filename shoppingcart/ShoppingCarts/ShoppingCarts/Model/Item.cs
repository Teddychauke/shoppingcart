﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCarts.Model
{
    public class Item
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string ButtonText { get; set; }
        public int Index { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
    }
}