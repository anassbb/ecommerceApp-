namespace ApplicationCore.Entities
{
    using ApplicationCore.Interfaces;
    public class CatalogType : BaseEntity , IAggregateRoot
    {
        public string Type { get; private set; }
        public CatalogType(string type)
        {
            Type = type;
        }     
    }
}
