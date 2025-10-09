using System;
using System.Collections.Generic;

namespace StationeryStoreDataLayer.Models;

public partial class UserTable
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool IsAdmin { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<AdressTable> AdressTables { get; set; } = new List<AdressTable>();

    public virtual ICollection<OrdersTable> OrdersTables { get; set; } = new List<OrdersTable>();
}
