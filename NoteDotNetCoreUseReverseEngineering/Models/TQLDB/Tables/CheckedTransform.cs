using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class CheckedTransform
{
    public int Id { get; set; }

    public string Checked { get; set; } = null!;

    public string Have { get; set; } = null!;

    public bool Value { get; set; }

    public string Agreement { get; set; } = null!;
}
