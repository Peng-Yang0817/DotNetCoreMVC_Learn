using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogOneForm000
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string FormName { get; set; } = null!;

    public string FormFileNum { get; set; } = null!;

    public DateTime LogTime { get; set; }
}
