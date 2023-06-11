using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check證書職級
{
    public int Id { get; set; }

    public string? 證書職級 { get; set; }

    public bool Tt1112 { get; set; }

    public int? EditAuth001Id { get; set; }

    public DateTime? EditTime { get; set; }
}
