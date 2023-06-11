using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogState009
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string Field { get; set; } = null!;

    public string Area { get; set; } = null!;

    public DateTime LogTime { get; set; }
}
