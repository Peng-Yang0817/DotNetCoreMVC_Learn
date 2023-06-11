using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogSchoolCtrl010
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public int OldSchoolCtrl005Id { get; set; }

    public int State002Id { get; set; }

    public int? NewSchoolCtrl005Id { get; set; }

    public string? OldDaShiueBuName { get; set; }

    public string? OldClassName { get; set; }

    public string? OldGroupName { get; set; }

    public string Year { get; set; } = null!;

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string? ApprovedUnit { get; set; }

    public bool SiJiJinXiuBuCw { get; set; }

    public bool SiJiZaiZhiZhuanBanCw { get; set; }

    public bool ErJiRiJianBuCw { get; set; }

    public bool ErJiJinXiuBuCw { get; set; }

    public bool ErJiJinXiuXueYuanCw { get; set; }

    public bool GauJrShengAcw { get; set; }

    public bool GauJungShengHuaGungTuMuJianJuLeiB1cw { get; set; }

    public bool GauJungShengWuGauJrDueiYingLeiB2cw { get; set; }

    public bool GauJungShengHuLiLeiB3cw { get; set; }

    public bool GauJungShengYaoXueYuWenLeiB4cw { get; set; }

    public bool YiBanWaiJiaMingAC1cw { get; set; }

    public bool JuanKeWaiJiaMingAC2cw { get; set; }

    public DateTime EditTime { get; set; }

    public int Auth001Id { get; set; }

    public DateTime LogTime { get; set; }
}
