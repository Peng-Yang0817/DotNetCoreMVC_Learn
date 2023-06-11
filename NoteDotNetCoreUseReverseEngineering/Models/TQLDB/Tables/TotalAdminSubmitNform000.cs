using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TotalAdminSubmitNform000
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public int SchoolCtrl001Id { get; set; }

    public string? Note { get; set; }

    public DateTime EditTime { get; set; }
}
