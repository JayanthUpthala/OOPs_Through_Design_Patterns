using System.Collections.Generic;

public abstract class ShoppingCartBaseDecorator : IShoppingCart
{
    public List<CartRow> CartList { get; set; }
    public decimal OriginalGrandTotal { get; set; } // before discounts
    protected IShoppingCart _shoppingCart;
    public ShoppingCartBaseDecorator(IShoppingCart shoppingCart)
    {
        _shoppingCart = shoppingCart;
    }
    public abstract decimal ComputeTotal();
}