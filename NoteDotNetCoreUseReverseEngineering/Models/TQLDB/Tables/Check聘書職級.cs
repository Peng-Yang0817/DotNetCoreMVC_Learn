using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check聘書職級
{
    public int Id { get; set; }

    public string 聘書職級 { get; set; } = null!;

    public bool Tt1112 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}
