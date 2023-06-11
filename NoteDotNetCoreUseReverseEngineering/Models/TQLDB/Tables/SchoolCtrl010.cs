using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl010
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl005 舊大學部 ID
    /// </summary>
    public int OldSchoolCtrl005Id { get; set; }

    /// <summary>
    /// FK State002 系科所狀態 ID
    /// </summary>
    public int State002Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl005 新大學部 ID
    /// </summary>
    public int? NewSchoolCtrl005Id { get; set; }

    /// <summary>
    /// 舊大學部系所名稱
    /// </summary>
    public string? OldDaShiueBuName { get; set; }

    /// <summary>
    /// 舊班名稱
    /// </summary>
    public string? OldClassName { get; set; }

    /// <summary>
    /// 舊組名稱
    /// </summary>
    public string? OldGroupName { get; set; }

    /// <summary>
    /// 大學部狀態改變年度
    /// </summary>
    public string Year { get; set; } = null!;

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string? ApprovedUnit { get; set; }

    /// <summary>
    /// 四技進修部
    /// </summary>
    public bool SiJiJinXiuBuCw { get; set; }

    /// <summary>
    /// 四技在職專班
    /// </summary>
    public bool SiJiZaiZhiZhuanBanCw { get; set; }

    /// <summary>
    /// 二技日間部
    /// </summary>
    public bool ErJiRiJianBuCw { get; set; }

    /// <summary>
    /// 二技進修部
    /// </summary>
    public bool ErJiJinXiuBuCw { get; set; }

    /// <summary>
    /// 進修學院能寫?
    /// </summary>
    public bool ErJiJinXiuXueYuanCw { get; set; }

    /// <summary>
    /// 高中生_A
    /// </summary>
    public bool GauJrShengAcw { get; set; }

    /// <summary>
    /// 化工土木建築類_B1
    /// </summary>
    public bool GauJungShengHuaGungTuMuJianJuLeiB1cw { get; set; }

    /// <summary>
    /// 無高職對應類科_B2
    /// </summary>
    public bool GauJungShengWuGauJrDueiYingLeiB2cw { get; set; }

    /// <summary>
    /// 護理類_B3
    /// </summary>
    public bool GauJungShengHuLiLeiB3cw { get; set; }

    /// <summary>
    /// 藥學語文類_B4
    /// </summary>
    public bool GauJungShengYaoXueYuWenLeiB4cw { get; set; }

    /// <summary>
    /// 外加一般_C1
    /// </summary>
    public bool YiBanWaiJiaMingAC1cw { get; set; }

    /// <summary>
    /// 外加專班_C2
    /// </summary>
    public bool JuanKeWaiJiaMingAC2cw { get; set; }

    /// <summary>
    /// 大學部狀態改變時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 大學部狀態改變者 ID
    /// </summary>
    public int Auth001Id { get; set; }
}
