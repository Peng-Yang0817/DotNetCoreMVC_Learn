using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogState003
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string Degree { get; set; } = null!;

    public int? CustomizeOrder { get; set; }

    public DateTime LogTime { get; set; }
}
