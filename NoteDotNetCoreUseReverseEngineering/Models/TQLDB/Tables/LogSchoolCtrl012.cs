using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogSchoolCtrl012
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public int OldSchoolCtrl007Id { get; set; }

    public int State002Id { get; set; }

    public int? NewSchoolCtrl007Id { get; set; }

    public string? OldJuanKeBuName { get; set; }

    public string? OldClassName { get; set; }

    public string? OldGroupName { get; set; }

    public string Year { get; set; } = null!;

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string? ApprovedUnit { get; set; }

    public bool WuZhuanCw { get; set; }

    public bool ErZhuanRiJianBuCw { get; set; }

    public bool ErZhuanYeJianBuCw { get; set; }

    public bool ErZhuanZaiZhiZhuanBanCw { get; set; }

    public bool ErZhuanJinXiuZhuanXiaoCw { get; set; }

    public DateTime EditTime { get; set; }

    public int Auth001Id { get; set; }

    public DateTime LogTime { get; set; }
}
