using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SysCtrl003
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    public string VarName { get; set; } = null!;

    public string VarValue { get; set; } = null!;

    public DateTime LasteditTime { get; set; }
}
