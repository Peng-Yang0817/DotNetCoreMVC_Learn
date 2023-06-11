using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Form005Old
{
    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public string? State { get; set; }

    public int GauJrGuoJungGuoShiauBuId { get; set; }

    public int GauJrShengJqs { get; set; }

    public int GuoJungShengJqs { get; set; }

    public int GuoShiauShengJqs { get; set; }
}
