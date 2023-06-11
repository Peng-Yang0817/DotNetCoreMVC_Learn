using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm0014
{
    /// <summary>
    /// PK 學院申請增設碩士班 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK OneForm001 表1 編碼
    /// </summary>
    public string OneForm001Id { get; set; } = null!;

    /// <summary>
    /// 支援開設之系所 數量
    /// </summary>
    public int SupportNum { get; set; }

    /// <summary>
    /// 專任師資人數，(A)教授
    /// </summary>
    public int? C1 { get; set; }

    /// <summary>
    /// 專任師資人數，(A)副教授
    /// </summary>
    public int? C2 { get; set; }

    /// <summary>
    /// 專任師資人數，(A)助理教授
    /// </summary>
    public int? C3 { get; set; }

    /// <summary>
    /// 專任師資人數，(A)講師
    /// </summary>
    public int? C4 { get; set; }

    /// <summary>
    /// 專任師資人數，(B)教授
    /// </summary>
    public int? C5 { get; set; }

    /// <summary>
    /// 專任師資人數，(B)副教授
    /// </summary>
    public int? C6 { get; set; }

    /// <summary>
    /// 專任師資人數，(B)助理教授
    /// </summary>
    public int? C7 { get; set; }

    /// <summary>
    /// 專任師資人數，(B)講師
    /// </summary>
    public int? C8 { get; set; }
}
