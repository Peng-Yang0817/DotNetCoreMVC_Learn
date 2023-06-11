using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Form003Old
{
    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public string? State { get; set; }

    public int GauJungBuId { get; set; }

    public int GauJrShengJqsA { get; set; }

    public int GauJungShengHuaGungTuMuJianJuLeiJosB { get; set; }

    public int GauJungShengWuGauJrDueiYiLeiKeJqsB { get; set; }

    public int GauJungShengHuLiLeiJqsB { get; set; }

    public int GauJungShengYauShiueYuWenLeiJqsB { get; set; }

    public int YiBanWaiJiaMingAjqsC { get; set; }

    public int JuanKeWaiJiaMingAjqsC { get; set; }
}
