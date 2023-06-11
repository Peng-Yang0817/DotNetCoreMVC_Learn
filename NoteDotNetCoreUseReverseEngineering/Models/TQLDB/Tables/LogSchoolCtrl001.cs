using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogSchoolCtrl001
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public string Tclnum { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string? SchoolArea { get; set; }

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public DateTime EditTime { get; set; }

    public int Auth001Id { get; set; }

    public DateTime LogTime { get; set; }
}
