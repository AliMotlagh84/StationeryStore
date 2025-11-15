using System;
using System.Collections.Generic;

namespace StationeryStoreDataLayer.Models;

public partial class BrandsTable
{
    public int BrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public virtual ICollection<ProductsTable> ProductsTables { get; set; } = new List<ProductsTable>();
}
