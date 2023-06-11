using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneExamine002StateName
{
    public int Id { get; set; }

    public int OneExamineStateNum { get; set; }

    public string OneExamineStateName { get; set; } = null!;
}
