﻿using Patisserie.Services.Order.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patisserie.Services.Order.Domain.OrderAggregate
{
    public class Order:Entity,IAggregateRoot
    {
        public DateTime CreatedDate { get;private set; }

        public Address Address { get;private set; }

        public string BuyerId { get;private set; }

        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;

        public Order(string buyerId, Address address)
        {
            _orderItems = new List<OrderItem>();
            CreatedDate=DateTime.Now;
            BuyerId = buyerId;
            Address = address;
        }

        public void AddOrderItem(string productId, string productName, decimal price, string pictureUrl, int quantity) 
        {
            var existProduct = _orderItems.Any(x => x.ProductId == productId);

            if (!existProduct)
            {
                var newOrderItem = new OrderItem(productId,productName,pictureUrl,price,quantity);
                _orderItems.Add(newOrderItem);
            }
        }

        public decimal getTotalPrice => _orderItems.Sum(x => x.Price);
    }
}