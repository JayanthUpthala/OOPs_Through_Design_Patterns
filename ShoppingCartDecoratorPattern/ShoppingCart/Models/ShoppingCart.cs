using System.Collections.Generic;

public class ShoppingCart : IShoppingCart // base component
{
    public List<CartRow> CartList { get; set; } // list of items in cart
    public decimal ComputeTotal()
    {
        decimal grandTotal = 0;
        foreach (CartRow row in CartList)
        {
            row.PriceTotal = row.Price * row.Quantity;
            grandTotal += row.PriceTotal;
        }
        return grandTotal;
    }
}
