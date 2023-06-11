using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Board001
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 檔案名稱
    /// </summary>
    public string FileName { get; set; } = null!;

    /// <summary>
    /// 檔案路徑
    /// </summary>
    public string FilePath { get; set; } = null!;

    /// <summary>
    /// 檔案建立者 Auth001
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// 檔案建立時間
    /// </summary>
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 檔案說明
    /// </summary>
    public string? Content { get; set; }
}
