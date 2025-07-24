public class ShoppingCartFirstTimeCustomerDecorator : ShoppingCartBaseDecorator
{
    public ShoppingCartFirstTimeCustomerDecorator(IShoppingCart shoppingCart)
    : base(shoppingCart) // call base class construct[or
    {
    }
    public override decimal ComputeTotal()
    {
        decimal grandTotal = 0;
        grandTotal = _shoppingCart.ComputeTotal();
        // check database to see if first time customer
        bool firstTimeCustomer = true;
        if (firstTimeCustomer) // apply further 7.5% discount
        {
            grandTotal = grandTotal - grandTotal * (7m / 100.0m);
        }
        return grandTotal;
    }
}