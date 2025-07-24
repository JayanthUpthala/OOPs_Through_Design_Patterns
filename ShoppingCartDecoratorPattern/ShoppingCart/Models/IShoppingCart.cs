using System.Collections.Generic;

public interface IShoppingCart // base interface
{
    List<CartRow> CartList { get; set; }
    decimal ComputeTotal();
}
