using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check補助情形
{
    public int Id { get; set; }

    public string? 補助情形 { get; set; }

    public int? EditAuth001Id { get; set; }

    public DateTime? EditTime { get; set; }
}
