using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogSysCtrl003
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string VarName { get; set; } = null!;

    public string VarValue { get; set; } = null!;

    public DateTime LasteditTime { get; set; }

    public DateTime LogTime { get; set; }
}
