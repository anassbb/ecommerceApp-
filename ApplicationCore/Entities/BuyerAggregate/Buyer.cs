namespace ApplicationCore.Entities.BuyerAggregate
{
    using ApplicationCore.Interfaces;
    using Ardalis.GuardClauses;
    using System.Collections.Generic;

    class Buyer : BaseEntity, IAggregateRoot
    {
        public string  IdentityGuid { get; private set; }

        public List<PaymentMethod> paymentMethod = new List<PaymentMethod>();

        public IEnumerable<PaymentMethod> paymentMethods => paymentMethod.AsReadOnly();
        public Buyer()
        {
            // required by EF
        }
        public Buyer(string identity) : this()
        {
            Guard.Against.NullOrEmpty(identity, nameof(identity));
            IdentityGuid = identity;
        }
    }
}
