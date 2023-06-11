using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Form002Old
{
    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public string? State { get; set; }

    public int DaShiueBuId { get; set; }

    public int SiJiRiJianBuJqsGauJung { get; set; }

    public int SiJiRiJianBuJqsGauJr { get; set; }

    public int SiJiJinXiuBuJqs { get; set; }

    public int SiJiZaiZhiZhuanBanJqs { get; set; }

    public int ErJiRiJianBuJqs { get; set; }

    public int ErJiJinXiuBuJqs { get; set; }

    public int ErJiJinXiuXueYuanJqs { get; set; }
}
