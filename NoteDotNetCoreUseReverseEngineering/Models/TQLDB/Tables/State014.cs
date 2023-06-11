using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class State014
{
    /// <summary>
    /// PK 本案是否申請過 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 本案是否申請過
    /// </summary>
    public string State014Name { get; set; } = null!;
}
