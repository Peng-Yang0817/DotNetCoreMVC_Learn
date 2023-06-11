using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check建物安全鑑定通過情形
{
    public int Id { get; set; }

    public string 建物安全鑑定通過情形 { get; set; } = null!;

    public bool Tt811 { get; set; }

    public bool Tt812 { get; set; }

    public bool Tt813 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}
