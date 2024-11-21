using System;
using System.Collections.Generic;

namespace BeautyShop.Models;

public partial class TblProduct
{
    public string ProductId { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; } = new List<TblOrderDetail>();
}
