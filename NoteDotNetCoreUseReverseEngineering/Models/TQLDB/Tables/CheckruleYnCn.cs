using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class CheckruleYnCn
{
    public int Id { get; set; }

    public string RuleYnCn { get; set; } = null!;

    public int EditAuth001d { get; set; }

    public DateTime EditTime { get; set; }
}
