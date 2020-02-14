namespace ApplicationCore.Entities.BasketAggregate
{
    using ApplicationCore.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    public class Basket: BaseEntity, IAggregateRoot 
    {
        public string BuyerId { get; private set; }
        public readonly List<BasketItem> item = new List<BasketItem>();
        public IReadOnlyCollection<BasketItem> Items => item.AsReadOnly(); 

        public Basket(string buyerId)
        {
            BuyerId = buyerId;
        }

        public void AddItem(int catalogItemId, decimal unitPrice,int quantity = 1)
        { 
            if (!Items.Any(i => i.CatalogItemId == catalogItemId))
            {
                item.Add(new BasketItem(catalogItemId, quantity, unitPrice));
                return;
            }
            var existingItem = Items.FirstOrDefault(i => i.CatalogItemId == catalogItemId);
            existingItem.AddQuantity(quantity);
        }

        public void RemoveEmptyItems() 
        {
            item.RemoveAll(i => i.Quantity == 0);
        }

        public void SetNewBuyerId(string buyerId)
        {
            BuyerId = buyerId;
        }
    }
}
