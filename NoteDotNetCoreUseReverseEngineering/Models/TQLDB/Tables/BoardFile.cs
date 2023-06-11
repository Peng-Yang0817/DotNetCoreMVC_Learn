using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class BoardFile
{
    /// <summary>
    /// PK 檔案 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK 公佈欄 編碼
    /// </summary>
    public int PublishBoardId { get; set; }

    /// <summary>
    /// 位置檔案名稱 隨機碼
    /// </summary>
    public string FileGuid { get; set; } = null!;

    /// <summary>
    /// 檔案名稱 原始檔案名稱
    /// </summary>
    public string FileName { get; set; } = null!;

    /// <summary>
    /// 檔案儲存位置
    /// </summary>
    public string FilePath { get; set; } = null!;

    /// <summary>
    /// FK 建置/編輯者 編碼
    /// </summary>
    public int EditAuth001Id { get; set; }

    /// <summary>
    /// 建置/編輯時間
    /// </summary>
    public DateTime EditTime { get; set; }
}
