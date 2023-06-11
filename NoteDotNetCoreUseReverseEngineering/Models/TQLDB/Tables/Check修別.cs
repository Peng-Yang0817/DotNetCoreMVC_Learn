using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check修別
{
    public int Id { get; set; }

    public string 修別 { get; set; } = null!;

    public int EditAuth001d { get; set; }

    public DateTime EditTime { get; set; }
}
