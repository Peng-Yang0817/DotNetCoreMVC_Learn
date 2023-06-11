using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class BoardCategory
{
    /// <summary>
    /// PK 類別 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 類別名稱
    /// </summary>
    public string? CategoryName { get; set; }
}
