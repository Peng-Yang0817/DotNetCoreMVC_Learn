using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm000
{
    /// <summary>
    /// PK 一階申請書名稱 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 一階申請書名稱
    /// </summary>
    public string FormName { get; set; } = null!;

    /// <summary>
    /// 一階上傳檔案分類
    /// </summary>
    public string FormFileNum { get; set; } = null!;
}
