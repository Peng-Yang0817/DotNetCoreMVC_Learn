using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Form004Old
{
    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public string? State { get; set; }

    public int JuanKeBuId { get; set; }

    public int WuZhuanJqs { get; set; }

    public int ErZhuanRiJianBuJqs { get; set; }

    public int ErZhuanYeJianBuJqs { get; set; }

    public int ErZhuanZaiZhiZhuanBanJqs { get; set; }

    public int ErZhuanJinXiuZhuanXiaoJqs { get; set; }
}
