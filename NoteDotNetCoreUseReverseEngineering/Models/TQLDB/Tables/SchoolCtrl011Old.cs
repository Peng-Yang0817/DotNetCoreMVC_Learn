using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl011Old
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl005 舊高中生 ID
    /// </summary>
    public int OldSchoolCtrl005Id { get; set; }

    /// <summary>
    /// FK State002 系科所狀態 ID
    /// </summary>
    public int State002Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl005 新高中生 ID
    /// </summary>
    public int NewSchoolCtrl005Id { get; set; }

    /// <summary>
    /// 舊高中生系所名稱
    /// </summary>
    public string OldGauJungBuName { get; set; } = null!;

    /// <summary>
    /// 高中生狀態改變年度
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// 是否停招招收「高職生」之名額A
    /// </summary>
    public bool StopGauJrShengJqsA { get; set; }

    /// <summary>
    /// 是否停招農業化工土木建築類B1
    /// </summary>
    public bool StopGauJungShengHuaGungTuMuJianJuLeiJosB1 { get; set; }

    /// <summary>
    /// 是否停招護理類B2
    /// </summary>
    public bool StopGauJungShengWuGauJrDueiYingLeiB2 { get; set; }

    /// <summary>
    /// 是否停招無高職對應類科
    /// </summary>
    public bool StopGauJungShengHuLiLeiB3 { get; set; }

    /// <summary>
    /// 是否停招護理類
    /// </summary>
    public bool StopGauJungShengYaoXueYuWenLeiB4 { get; set; }

    /// <summary>
    /// 是否停招藥學語文類
    /// </summary>
    public bool StopYiBanWaiJiaMingAjqsC1 { get; set; }

    /// <summary>
    /// 是否停招一般外加名額
    /// </summary>
    public bool StopJuanKeWaiJiaMingAjqsC2 { get; set; }

    /// <summary>
    /// 狀態改變時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 大學部狀態改變者 ID
    /// </summary>
    public int Auth001Id { get; set; }
}
