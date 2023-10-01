﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using A_RoutingExamples.Models;

namespace A_RoutingExamples.Services
{
	public class ProductService
	{
		private static readonly IDictionary<string, Product> _allProducts =
			new Dictionary<string, Product>
			{
				{ "big-widget", new Product("Big Widget", 123) },
				{ "super-fancy-widget", new Product("Super fancy widget", 456) },
			};

		public Product GetProduct(string name)
		{
			_allProducts.TryGetValue(name, out var product);
			return product;
		}

		public List<Product> Search(string term, StringComparison comparisonType)
		{
			return _allProducts
				.Where(x => x.Value.Name.Contains(term, comparisonType))
				.Select(x => x.Value)
				.ToList();
		}
	}
}
