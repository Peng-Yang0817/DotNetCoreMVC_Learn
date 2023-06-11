using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm0014Support
{
    /// <summary>
    /// PK Form001_4_支援開設之系所資料
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK 學院申請增設碩士班  編碼
    /// </summary>
    public int OneForm0014id { get; set; }

    /// <summary>
    /// FK 支援開設之系所  編碼
    /// </summary>
    public int? SchoolCtrl004Id { get; set; }

    /// <summary>
    /// FK 支援開設之系所  編碼
    /// </summary>
    public int? State016Id { get; set; }

    /// <summary>
    /// 評鑑名稱
    /// </summary>
    public string? C1 { get; set; }

    /// <summary>
    /// 評鑑年度
    /// </summary>
    public string? C2 { get; set; }

    /// <summary>
    /// 評鑑結果
    /// </summary>
    public string? C3 { get; set; }

    /// <summary>
    /// FK State017 設立年限 編碼
    /// </summary>
    public int? State017Id { get; set; }

    /// <summary>
    /// 碩士班設立學年度
    /// </summary>
    public string? State017Year { get; set; }
}
