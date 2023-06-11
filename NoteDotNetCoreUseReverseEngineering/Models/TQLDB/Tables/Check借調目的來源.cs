using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check借調目的來源
{
    public int Id { get; set; }

    public string 借調目的來源 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}
