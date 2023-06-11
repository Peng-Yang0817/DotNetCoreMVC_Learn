using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class 學制填報限制
{
    public int Id { get; set; }

    public int? SchoolCtrl001Id { get; set; }

    public int? SchoolCtrl002Id { get; set; }

    public int? SchoolCtrl003Id { get; set; }

    public int? SchoolCtrl004Id { get; set; }

    public int? SchoolCtrl005Id { get; set; }

    public int? SchoolCtrl007Id { get; set; }

    public bool? GauJrShengAcwEnabled { get; set; }

    public bool? GauJungShengHuaGungTuMuJianJuLeiB1cwEnabled { get; set; }

    public bool? GauJungShengWuGauJrDueiYingLeiB2cwEnabled { get; set; }

    public bool? GauJungShengHuLiLeiB3cwEnabled { get; set; }

    public bool? GauJungShengYaoXueYuWenLeiB4cwEnabled { get; set; }

    public bool? YiBanWaiJiaMingAC1cwEnabled { get; set; }

    public bool? JuanKeWaiJiaMingAC2cwEnabled { get; set; }

    public bool? SiJiJinXiuBuCwEnabled { get; set; }

    public bool? SiJiZaiZhiZhuanBanCwEnabled { get; set; }

    public bool? ErJiRiJianBuCwEnabled { get; set; }

    public bool? ErJiJinXiuBuCwEnabled { get; set; }

    public bool? ErJiJinXiuXueYuanCwEnabled { get; set; }

    public bool? BoShiBanCwEnabled { get; set; }

    public bool? ShuoShiBanCwEnabled { get; set; }

    public bool? ShuoShiZaiZhiZhuanBanCwEnabled { get; set; }

    public bool? WuZhuanCwEnabled { get; set; }

    public bool? ErZhuanRiJianBuCwEnabled { get; set; }

    public bool? ErZhuanYeJianBuCwEnabled { get; set; }

    public bool? ErZhuanZaiZhiZhuanBanCwEnabled { get; set; }

    public bool? ErZhuanJinXiuZhuanXiaoCwEnabled { get; set; }

    public int? Year { get; set; }
}
