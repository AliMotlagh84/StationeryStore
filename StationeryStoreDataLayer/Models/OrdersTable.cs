using System;
using System.Collections.Generic;

namespace StationeryStore.DataLayer.Models;

public partial class OrdersTable
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime Date { get; set; }

    public long Amount { get; set; }

    public string OrderInfo { get; set; } = null!;

    public virtual UserTable User { get; set; } = null!;
}
