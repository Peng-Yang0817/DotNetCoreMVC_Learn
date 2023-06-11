using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class BoardPublish
{
    /// <summary>
    /// PK 公佈欄 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK 類別 編碼
    /// </summary>
    public int BoardCategoryId { get; set; }

    /// <summary>
    /// 標題/下載檔案名稱
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// 文字內容
    /// </summary>
    public string? Contents { get; set; }

    public string? State { get; set; }

    /// <summary>
    /// 公佈時間
    /// </summary>
    public DateTime BoardTime { get; set; }

    /// <summary>
    /// FK 建置/編輯者 編碼
    /// </summary>
    public int EditAuth001Id { get; set; }

    /// <summary>
    /// 建置/編輯時間
    /// </summary>
    public DateTime EditTime { get; set; }
}
