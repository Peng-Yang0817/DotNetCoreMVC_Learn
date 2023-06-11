using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check系所類別代碼
{
    public int Id { get; set; }

    public string 系所類別代碼 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public bool Tt311 { get; set; }
}
