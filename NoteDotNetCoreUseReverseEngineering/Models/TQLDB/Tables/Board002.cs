using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Board002
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 公告Title
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// 公告內容
    /// </summary>
    public string Content { get; set; } = null!;

    /// <summary>
    /// 公告建立者 Auth001
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// 公告建立時間
    /// </summary>
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 公告狀態(開啟,關閉)
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// 公告開始時間
    /// </summary>
    public DateTime StartTime { get; set; }

    /// <summary>
    /// 公告結束時間
    /// </summary>
    public DateTime EndTime { get; set; }

    /// <summary>
    /// 附加檔案名稱
    /// </summary>
    public string? FileName { get; set; }

    /// <summary>
    /// 附加檔案路徑
    /// </summary>
    public string? FilePath { get; set; }
}
