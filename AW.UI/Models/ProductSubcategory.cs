﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AW.UI.Models
{
    public class ProductSubcategory
    {
        public int Key { get; set; }
        public int? ProductCategoryKey { get; set; }
        public string Name { get; set; }
    }
}