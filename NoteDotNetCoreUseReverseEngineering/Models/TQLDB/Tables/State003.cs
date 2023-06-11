using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State003
{
    public int Id { get; set; }

    public string Degree { get; set; } = null!;

    public int? CustomizeOrder { get; set; }
}
