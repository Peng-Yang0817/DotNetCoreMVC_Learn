using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State008State004
{
    public int State008Id { get; set; }

    public int State004Id { get; set; }

    public string Category { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public string? Ps { get; set; }

    public string FormRule { get; set; } = null!;
}
