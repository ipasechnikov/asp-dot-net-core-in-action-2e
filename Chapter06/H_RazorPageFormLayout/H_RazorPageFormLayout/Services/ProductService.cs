using System.Collections.Generic;

using H_RazorPageFormLayout.Models;

namespace H_RazorPageFormLayout.Services
{
	public class ProductService
	{
		public readonly Dictionary<int, ProductDetails> _products = new Dictionary<int, ProductDetails>
		{
			{1, new ProductDetails("Apple iPad", 200, 50) },
			{2, new ProductDetails("Surface", 2200, 10) },
			{3, new ProductDetails("XPS 15", 1600, 3) },
		};

		public ProductDetails GetProduct(int productId)
		{
			if (_products.TryGetValue(productId, out ProductDetails product))
			{
				return product; 
			}
			return null;
		}

		public void UpdateProduct(int productId, string newName, decimal newSellPrice)
		{
			ProductDetails product = GetProduct(productId);
			if (product is null)
			{
				return;
			}

			product.ProductName = newName;
			product.SellPrice = newSellPrice;
		}
	}
}
