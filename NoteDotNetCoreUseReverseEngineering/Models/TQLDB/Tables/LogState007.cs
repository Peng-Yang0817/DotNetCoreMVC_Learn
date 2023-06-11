using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogState007
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string ViewName { get; set; } = null!;

    public string ItemValue { get; set; } = null!;

    public int State003Id { get; set; }

    public DateTime LogTime { get; set; }
}
