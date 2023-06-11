using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State007
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// View程式名稱
    /// </summary>
    public string ViewName { get; set; } = null!;

    /// <summary>
    /// SelectItem Value
    /// </summary>
    public string ItemValue { get; set; } = null!;

    public int State003Id { get; set; }
}
