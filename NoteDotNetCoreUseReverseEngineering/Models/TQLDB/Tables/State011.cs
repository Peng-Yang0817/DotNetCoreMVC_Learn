using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State011
{
    /// <summary>
    /// PK 增設類別 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK 一階表單名稱 編碼
    /// </summary>
    public int OneForm000Id { get; set; }

    /// <summary>
    /// 增設類別名稱
    /// </summary>
    public string State011Name { get; set; } = null!;
}
