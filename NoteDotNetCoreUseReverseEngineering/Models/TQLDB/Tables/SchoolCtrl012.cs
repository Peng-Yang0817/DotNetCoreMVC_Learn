using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl012
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl007 舊專科 ID
    /// </summary>
    public int OldSchoolCtrl007Id { get; set; }

    /// <summary>
    /// FK State002 系科所狀態 ID
    /// </summary>
    public int State002Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl007 新專科 ID
    /// </summary>
    public int? NewSchoolCtrl007Id { get; set; }

    /// <summary>
    /// 舊專科系所名稱
    /// </summary>
    public string? OldJuanKeBuName { get; set; }

    /// <summary>
    /// 舊班別名稱
    /// </summary>
    public string? OldClassName { get; set; }

    /// <summary>
    /// 舊組別名稱
    /// </summary>
    public string? OldGroupName { get; set; }

    /// <summary>
    /// 專科狀態改變年度
    /// </summary>
    public string Year { get; set; } = null!;

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string? ApprovedUnit { get; set; }

    /// <summary>
    /// 五專能寫?
    /// </summary>
    public bool WuZhuanCw { get; set; }

    /// <summary>
    /// 二專日間部
    /// </summary>
    public bool ErZhuanRiJianBuCw { get; set; }

    /// <summary>
    /// 二專夜間部
    /// </summary>
    public bool ErZhuanYeJianBuCw { get; set; }

    /// <summary>
    /// 二專在職專班
    /// </summary>
    public bool ErZhuanZaiZhiZhuanBanCw { get; set; }

    /// <summary>
    /// 進修專校
    /// </summary>
    public bool ErZhuanJinXiuZhuanXiaoCw { get; set; }

    /// <summary>
    /// 狀態改變時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 大學部狀態改變者 ID
    /// </summary>
    public int Auth001Id { get; set; }
}
