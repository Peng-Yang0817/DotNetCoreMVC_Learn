using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm0012
{
    /// <summary>
    /// PK 系設立碩士班  編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK OneForm001 表1 編碼
    /// </summary>
    public string OneForm001Id { get; set; } = null!;

    /// <summary>
    /// FK State016 評鑑成績 編碼
    /// </summary>
    public int State016Id { get; set; }

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
    public int State017Id { get; set; }

    /// <summary>
    /// 日間碩士班名稱
    /// </summary>
    public string? C4 { get; set; }

    /// <summary>
    /// 系增設學年度
    /// </summary>
    public string? C5 { get; set; }

    /// <summary>
    /// 申請時已設立滿?年
    /// </summary>
    public string? C6 { get; set; }

    /// <summary>
    /// 專任師資人數，教授
    /// </summary>
    public int C7 { get; set; }

    /// <summary>
    /// 專任師資人數，副教授
    /// </summary>
    public int C8 { get; set; }

    /// <summary>
    /// 專任師資人數，助理教授
    /// </summary>
    public int C9 { get; set; }

    /// <summary>
    /// 專任師資人數，講師
    /// </summary>
    public int C10 { get; set; }
}
