using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check有無合約
{
    public int Id { get; set; }

    public string 有無合約 { get; set; } = null!;

    public bool Tt83 { get; set; }

    public int EditAuth001d { get; set; }

    public DateTime EditTime { get; set; }
}
