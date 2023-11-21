using Patisserie.Services.Order.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patisserie.Services.Order.Domain.OrderAggregate
{
    public class OrderItem:Entity
    {
        public string ProductId { get; private set; }

        public string ProductName { get; private set; }

        public string PictureUrl { get; private set; }

        public Decimal Price { get;private set; }
        public int Quantity { get; private set; }

        public OrderItem() { }
        public OrderItem(string productId, string productName, string pictureUrl, decimal price, int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            PictureUrl = pictureUrl;
            Price = price;
            Quantity = quantity;
        }

        public void UpdateOrderItem(string productName,string pictureUrl, decimal price, int quantity)
        {
            ProductName = productName;
            PictureUrl = pictureUrl;
            Price = price;
            Quantity = quantity;
        }
    }
}
