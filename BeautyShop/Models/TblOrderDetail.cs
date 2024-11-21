using System;
using System.Collections.Generic;

namespace BeautyShop.Models;

public partial class TblOrderDetail
{
    public string OrderId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public bool Status { get; set; }

    public virtual TblOrder Order { get; set; } = null!;

    public virtual TblProduct Product { get; set; } = null!;
}
