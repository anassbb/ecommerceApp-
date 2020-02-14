using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.OrderAggregate
{
    class Order
    {
        public Order()
        {

        }
        public Order(string buyerId, Address shipToAddress, List<OrderItem> items)
        {
            Guard.Against.NullOrEmpty(buyerId, nameof(buyerId));
            Guard.Against.Null(shipToAddress, nameof(shipToAddress));
            Guard.Against.Null(items, nameof(items));

            BuyerId = buyerId;
            ShipToAddress = shipToAddress;
            orderItem = items;
        }

        public string BuyerId { get;private set; }

        public DateTimeOffset OrderDate { get; private set; } = DateTimeOffset.Now;

        public Address ShipToAddress { get; set; }

        private readonly List<OrderItem> orderItem = new List<OrderItem>();

        public IReadOnlyCollection<OrderItem> OrderItems => orderItem.AsReadOnly();


        public decimal Total() 
        {
            var total = 0m;
            foreach(var item in orderItem)
            {
                total += item.UnitPrice * item.Units;
            }
            return total;
        }
    }

}
