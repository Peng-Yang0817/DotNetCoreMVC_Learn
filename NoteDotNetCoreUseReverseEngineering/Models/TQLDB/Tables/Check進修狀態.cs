using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check進修狀態
{
    public int Id { get; set; }

    public string? 進修狀態 { get; set; }

    public int? EditAuth001Id { get; set; }

    public DateTime? EditTime { get; set; }
}
