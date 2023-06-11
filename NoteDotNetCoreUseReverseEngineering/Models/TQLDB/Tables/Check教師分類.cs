using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check教師分類
{
    public int Id { get; set; }

    public string 教師分類 { get; set; } = null!;

    public bool Tt1112 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}
