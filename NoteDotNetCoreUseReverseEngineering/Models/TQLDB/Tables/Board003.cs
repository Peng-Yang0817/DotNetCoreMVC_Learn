using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Board003
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 問與答Title
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// 問與答內容
    /// </summary>
    public string Content { get; set; } = null!;

    /// <summary>
    /// FK Board001 問與答檔案名稱
    /// </summary>
    public int? Board001Id { get; set; }

    /// <summary>
    /// 問與答建立者 Auth001
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// 問與答建立時間
    /// </summary>
    public DateTime CreateTime { get; set; }
}
