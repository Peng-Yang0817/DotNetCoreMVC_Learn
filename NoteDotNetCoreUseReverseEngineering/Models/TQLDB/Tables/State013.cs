using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State013
{
    /// <summary>
    /// PK 建議送審類別 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 建議送審類別
    /// </summary>
    public string State013Name { get; set; } = null!;
}
