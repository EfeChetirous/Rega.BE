using Rega.DataHandler.Entity;
using System;
using System.Collections.Generic;

namespace Rega.DataHandler.Entities;

public partial class OneToOne : BaseEntity
{
    public int Id { get; set; }

    public int? FirstCompetitorId { get; set; }

    public int? SecondCompetatorId { get; set; }

    public int? WinnerOfcompetitior { get; set; }

    public int? FirstCompetitorPoint { get; set; }

    public int? SecondCompetatorPoint { get; set; }

}
