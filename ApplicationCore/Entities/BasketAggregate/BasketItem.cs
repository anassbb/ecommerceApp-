namespace ApplicationCore.Entities.BasketAggregate
{
    public class BasketItem
    {
        public decimal UnitPrice { get;  private set; }
        public int Quantity { get;  private set; }
        public int CatalogItemId { get;  private set; }
        public int BasketId { get;  private set; }

        public BasketItem(int catalogItemId,int quantity, decimal unitPrice)
        {
            catalogItemId = catalogItemId;
            Quantity = quantity;
            unitPrice = unitPrice;
        }

        public void AddQuantity(int quantity) 
        {
            Quantity += quantity; 
        }

        public void SetNewQuantity(int quantity) 
        {
            Quantity = quantity; 
        }
    }
}
