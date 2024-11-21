using System;
using System.Collections.Generic;

namespace BeautyShop.Models;

public partial class TblOrder
{
    public string OrderId { get; set; } = null!;

    public DateOnly Date { get; set; }

    public decimal Total { get; set; }

    public bool Status { get; set; }

    public string? UserId { get; set; }

    public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; } = new List<TblOrderDetail>();

    public virtual TblUser? User { get; set; }
}
