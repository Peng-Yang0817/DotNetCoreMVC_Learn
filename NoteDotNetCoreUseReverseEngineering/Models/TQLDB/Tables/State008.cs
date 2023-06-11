using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State008
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK State004 表B 學制調整 ID
    /// </summary>
    public int State004Id { get; set; }

    /// <summary>
    /// 檢核規則文字顯示
    /// </summary>
    public string FormRule { get; set; } = null!;
}
