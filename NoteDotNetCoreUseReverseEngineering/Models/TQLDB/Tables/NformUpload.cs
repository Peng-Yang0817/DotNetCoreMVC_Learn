using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class NformUpload
{
    /// <summary>
    /// PK 總量三階上傳 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 學年度
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// FK SchoolCtrl001 學校 編碼
    /// </summary>
    public int SchoolCtrl001Id { get; set; }

    /// <summary>
    /// 檔案名稱
    /// </summary>
    public string FileName { get; set; } = null!;

    /// <summary>
    /// 檔案路徑
    /// </summary>
    public string FilePath { get; set; } = null!;

    /// <summary>
    /// 檔案實存名稱
    /// </summary>
    public string FileGuid { get; set; } = null!;

    /// <summary>
    /// 創建/修改時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// 創建/修改者
    /// </summary>
    public int EditAuth001 { get; set; }
}
