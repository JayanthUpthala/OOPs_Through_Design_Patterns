public class ShoppingCartHolidaySaleDecorator : ShoppingCartBaseDecorator
{
    public ShoppingCartHolidaySaleDecorator(IShoppingCart shoppingCart)
    : base(shoppingCart) // call base class construct[or
    {
    }
    public override decimal ComputeTotal()
    { // 10% holiday sale
        decimal grandTotal = 0;
        grandTotal = _shoppingCart.ComputeTotal();
        grandTotal = grandTotal - (grandTotal * (decimal)(10 / 100.0));
        return grandTotal;
    }
}