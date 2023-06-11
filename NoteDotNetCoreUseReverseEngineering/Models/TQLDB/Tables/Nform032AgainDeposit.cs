using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform032AgainDeposit
{
    public string? SchoolName { get; set; }

    public int? SchoolCtrl001Id { get; set; }

    public string? CollegeName { get; set; }

    public int? SchoolCtrl002Id { get; set; }

    public string? TotalName { get; set; }

    public string DaShiueBuName { get; set; } = null!;

    public string? ClassName { get; set; }

    public string? GroupName { get; set; }

    public string? DepartmentAreaName { get; set; }

    public int SchoolCtrl005Id { get; set; }

    public string GauJrShengAstate { get; set; } = null!;

    public int? NewGauJrShengJqsA { get; set; }

    public int? NewGauJrShengAdeposit { get; set; }

    public int? OldGauJrShengJqsA { get; set; }

    public int? GauJrShengJqsATolalShortfall { get; set; }

    public int? GauJrShengJqsAAgainDeposit { get; set; }
}
