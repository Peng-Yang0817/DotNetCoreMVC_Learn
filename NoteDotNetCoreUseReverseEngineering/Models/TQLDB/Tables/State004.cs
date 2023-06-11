using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State004
{
    public int Id { get; set; }

    public string Category { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public string? Ps { get; set; }

    public bool? Enabled { get; set; }
}
