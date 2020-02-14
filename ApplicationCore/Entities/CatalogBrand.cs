namespace ApplicationCore.Entities
{
    using ApplicationCore.Interfaces;
    public class CatalogBrand : BaseEntity, IAggregateRoot
    {
        public string Brand { get; private set; }

        public CatalogBrand(string brand)
        {
            Brand = brand;
        }
    }
}
