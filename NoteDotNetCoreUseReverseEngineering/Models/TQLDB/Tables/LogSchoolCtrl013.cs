using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogSchoolCtrl013
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public int OldSchoolCtrl008Id { get; set; }

    public int State002Id { get; set; }

    public int? NewSchoolCtrl008Id { get; set; }

    public string? OldGauJrGuoJungGuoShiauBuName { get; set; }

    public string? OldClassName { get; set; }

    public string? OldGroupName { get; set; }

    public string Year { get; set; } = null!;

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string? ApprovedUnit { get; set; }

    public bool GauJrShengCw { get; set; }

    public bool GuoJungShengCw { get; set; }

    public bool GuoShiauShengCw { get; set; }

    public DateTime EditTime { get; set; }

    public int Auth001Id { get; set; }

    public DateTime LogTime { get; set; }
}
