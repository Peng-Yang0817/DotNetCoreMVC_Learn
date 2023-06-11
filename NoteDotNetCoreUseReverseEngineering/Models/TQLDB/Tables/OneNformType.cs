using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneNformType
{
    public int Id { get; set; }

    public string OneNformType1 { get; set; } = null!;

    public string OneNformTypeName { get; set; } = null!;

    public string? OneNformAdjustment { get; set; }
}
