using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State012
{
    /// <summary>
    /// PK 招生學制  編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK 一階表單名稱 編碼
    /// </summary>
    public int OneForm000Id { get; set; }

    /// <summary>
    /// 招生學制 名稱
    /// </summary>
    public string State012Name { get; set; } = null!;
}
