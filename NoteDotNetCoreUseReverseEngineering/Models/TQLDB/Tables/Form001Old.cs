using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Form001Old
{
    /// <summary>
    /// 7878787
    /// </summary>
    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public string State { get; set; } = null!;

    public int ShuoBoShrBanId { get; set; }

    public int BoShiBanJqs { get; set; }

    public int ShuoShiBanJqs { get; set; }

    public int ShuoShiZaiZhiZhuanBanJqs { get; set; }
}
