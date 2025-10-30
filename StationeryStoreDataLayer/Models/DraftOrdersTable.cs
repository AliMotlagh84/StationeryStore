using System;
using System.Collections.Generic;

namespace StationeryStore.DataLayer.Models;

public partial class DraftOrdersTable
{
    public int DraftOrderId { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int BrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public int RequestedCount { get; set; }

    public long Amount { get; set; }

    public long TotalAmount { get; set; }

    public virtual BrandsTable Brand { get; set; } = null!;

    public virtual ProductsTable Product { get; set; } = null!;

    public virtual UserTable User { get; set; } = null!;
}
