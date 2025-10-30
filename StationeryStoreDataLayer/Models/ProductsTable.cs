using System;
using System.Collections.Generic;

namespace StationeryStore.DataLayer.Models;

public partial class ProductsTable
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int BrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public int Count { get; set; }

    public long Amount { get; set; }

    public DateTime AddTime { get; set; }

    public virtual BrandsTable Brand { get; set; } = null!;
}
