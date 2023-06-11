using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State009
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 用途名稱(當群組使用)
    /// </summary>
    public string Field { get; set; } = null!;

    /// <summary>
    /// 護理農業化工及土木領域
    /// </summary>
    public string Area { get; set; } = null!;
}
