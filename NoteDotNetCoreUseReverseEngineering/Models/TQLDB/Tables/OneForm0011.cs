using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm0011
{
    /// <summary>
    /// PK 獨立研究所 編碼
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
    /// 是/否。申請時，碩士在職專班已設立
    /// </summary>
    public int? State018Id { get; set; }

    /// <summary>
    /// 碩士在職專班/日間碩士班已設立滿?年
    /// </summary>
    public string? State018Year { get; set; }

    /// <summary>
    /// 專任師資人數，教授
    /// </summary>
    public int C4 { get; set; }

    /// <summary>
    /// 專任師資人數，副教授
    /// </summary>
    public int C5 { get; set; }

    /// <summary>
    /// 專任師資人數，助理教授
    /// </summary>
    public int C6 { get; set; }
}
