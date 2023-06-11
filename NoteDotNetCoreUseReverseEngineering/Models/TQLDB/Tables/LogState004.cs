using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogState004
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string Category { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public string? Ps { get; set; }

    public bool? Enabled { get; set; }

    public DateTime LogTime { get; set; }
}
