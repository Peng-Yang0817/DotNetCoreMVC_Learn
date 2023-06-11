using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check校區
{
    public int Id { get; set; }

    public string 校區 { get; set; } = null!;

    public bool Tt811 { get; set; }

    public bool Tt812 { get; set; }

    public bool Tt813 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}
