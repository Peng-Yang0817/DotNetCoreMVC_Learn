using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check實習期間
{
    public int Id { get; set; }

    public string 實習期間 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public bool Tt472部分學分校外實習學生數一般生採計 { get; set; }
}
