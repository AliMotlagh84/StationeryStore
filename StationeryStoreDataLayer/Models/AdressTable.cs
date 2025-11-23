using System;
using System.Collections.Generic;

namespace StationeryStoreDataLayer.Models;

public partial class AdressTable
{
    public int AdressId { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string Alley { get; set; } = null!;

    public string HouseNumber { get; set; } = null!;

    public long PostalCode { get; set; }

    public virtual UserTable User { get; set; } = null!;
}
