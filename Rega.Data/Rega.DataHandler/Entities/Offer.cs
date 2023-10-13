using Rega.DataHandler.Entity;
using System;
using System.Collections.Generic;

namespace Rega.DataHandler.Entities;

public partial class Offer : BaseEntity
{
    public int Id { get; set; }

    public string? OfferName { get; set; }

    public DateTime? OfferStarDate { get; set; }

    public DateTime? OfferEndDate { get; set; }

    public string? OfferMessage { get; set; }

    public bool? IsActive { get; set; }

    public int? UserId { get; set; }

}
