using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm0013Support
{
    /// <summary>
    /// PK Form001_3_支援開設之系所資料
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK 碩士學位學程之增設  編碼
    /// </summary>
    public int OneForm0013id { get; set; }

    /// <summary>
    /// FK 支援開設之系所  編碼
    /// </summary>
    public int? SchoolCtrl004Id { get; set; }

    /// <summary>
    /// FK State016 評鑑成績 編碼
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

    /// <summary>
    /// 支援系所之專任師資人數，教授
    /// </summary>
    public int? C4 { get; set; }

    /// <summary>
    /// 支援系所之專任師資人數，副教授
    /// </summary>
    public int? C5 { get; set; }

    /// <summary>
    /// 支援系所之專任師資人數，助理教授
    /// </summary>
    public int? C6 { get; set; }

    /// <summary>
    /// 支援系所之專任師資人數，講師
    /// </summary>
    public int? C7 { get; set; }
}
