public class ShoppingCartGT500Decorator : ShoppingCartBaseDecorator
{
    public ShoppingCartGT500Decorator(IShoppingCart shoppingCart)
    : base(shoppingCart) // call base class construct[or
    {
    }
    public override decimal ComputeTotal()
    {
        decimal grandTotal = 0;
        grandTotal = _shoppingCart.ComputeTotal();
        if (grandTotal > 500)
        {
            grandTotal = grandTotal - (grandTotal * (decimal)(5 / 100.0));
        }
        return grandTotal;
    }
}
