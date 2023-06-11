using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check任職狀態
{
    public int Id { get; set; }

    public string 任職狀態 { get; set; } = null!;

    public bool Tt1111 { get; set; }

    public bool Tt1112 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}
