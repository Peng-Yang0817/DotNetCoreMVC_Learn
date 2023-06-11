using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State002
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 系科所狀態名稱
    /// </summary>
    public string AdjustName { get; set; } = null!;

    /// <summary>
    /// 系科所狀態建立時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 系科所狀態建立者ID
    /// </summary>
    public int Auth001Id { get; set; }
}
