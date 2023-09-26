﻿using C_PageHandlers.Models;
using System.Collections.Generic;
using System.Linq;

namespace C_PageHandlers.Services
{
    public class SearchService
    {
        // These would normally be loaded from a database for example
        private static readonly List<Product> _items = new List<Product>
        {
            new Product{ Name="iPad" },
            new Product{ Name="iPod" },
            new Product{ Name="iMac" },
            new Product{ Name="Mac Pro" },
            new Product{ Name="Mac mini" },
        };

        public List<Product> SearchProducts(string term)
        {
            return _items.Where(x => x.Name.Contains(term)).ToList();
        }
    }
}
