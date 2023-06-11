using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneFormUpload
{
    /// <summary>
    /// PK 一階表單pdf上傳 編碼
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 學年度
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// FK 學校 編碼
    /// </summary>
    public int SchoolCtrl001Id { get; set; }

    /// <summary>
    /// FK 一階表單名稱 編碼
    /// </summary>
    public int OneForm000Id { get; set; }

    /// <summary>
    /// 檔案名稱
    /// </summary>
    public string FileName { get; set; } = null!;

    /// <summary>
    /// 創建/修改時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK 創建/修改者 編碼
    /// </summary>
    public int EditAuth001Id { get; set; }
}
