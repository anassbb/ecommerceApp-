using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.OrderAggregate
{
    
    class OrderItem
    {
        public CatalogItemOrdered ItemOrdered { get;private set; }
        public decimal UnitPrice { get;private set; }
        public int Units { get;private set; }

        public OrderItem()
        {
                
        }
        public OrderItem(CatalogItemOrdered itemOrdered, decimal unitPrice, int units)
        {
            ItemOrdered = itemOrdered;
            UnitPrice = unitPrice;
            Units = units;
        }
    }
}
