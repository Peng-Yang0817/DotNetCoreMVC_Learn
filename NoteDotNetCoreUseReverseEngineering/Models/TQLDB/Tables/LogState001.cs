using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogState001
{
    public string Atype { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string StateName { get; set; } = null!;

    public string StatePhase { get; set; } = null!;

    public DateTime LogTime { get; set; }
}
