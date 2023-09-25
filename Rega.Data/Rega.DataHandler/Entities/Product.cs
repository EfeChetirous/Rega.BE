using Rega.DataHandler.Entity;
using System;
using System.Collections.Generic;

namespace Rega.DataHandler.Entities;

public partial class Product : BaseEntity
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public int? StockCount { get; set; }
}
