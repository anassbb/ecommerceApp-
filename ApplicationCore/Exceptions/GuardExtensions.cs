﻿namespace ApplicationCore.Exceptions
{
    using ApplicationCore.Entities.BasketAggregate;
    using Ardalis.GuardClauses;
    public static class GuardExtensions
    {
        public static void NullBasket(this IGuardClause guardClause, int basketId, Basket  basket ) 
        {
            if (basket == null)
                throw new BasketNotFoundException(basketId);
        }
    }
}
