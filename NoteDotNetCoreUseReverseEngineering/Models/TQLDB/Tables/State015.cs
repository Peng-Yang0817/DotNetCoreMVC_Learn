using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State015
{
    /// <summary>
    /// PK 增設別 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK 一階表單名稱 編碼
    /// </summary>
    public int OneForm000Id { get; set; }

    /// <summary>
    /// 增設別名稱
    /// </summary>
    public string State015Name { get; set; } = null!;
}
