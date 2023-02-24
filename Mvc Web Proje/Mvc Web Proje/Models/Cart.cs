using Mvc_Web_Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Web_Proje.Models
{
    public class Cart
    {
        private List<CartLine> cartLines = new List<CartLine>();
        public List<CartLine> CartLines
        {
            get{return cartLines; }
        }
        public  void AddProduct(Product product, int quantity)
        {
            var line = cartLines.FirstOrDefault(i => i.Product.Id == product.Id);
            if (line==null)
            {
                cartLines.Add(new CartLine() { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void DeleteProduct(Product product)
        {
            cartLines.RemoveAll(i => i.Product.Id == product.Id);
        }
        public double Total()
        {
            return cartLines.Sum(i => i.Product.Price * i.Quantity);
        }
        public void Clear()
        {
            cartLines.Clear();
        }
    }



    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}