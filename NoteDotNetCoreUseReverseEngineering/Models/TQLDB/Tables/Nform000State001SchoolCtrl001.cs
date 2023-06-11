using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform000State001SchoolCtrl001
{
    public int SchoolCtrl001Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public string Tclnum { get; set; } = null!;

    public int? State001Id { get; set; }

    public string? StatePhase { get; set; }

    public string? StateName { get; set; }

    public string? SchoolNote { get; set; }

    public string? TotalNote { get; set; }

    public string? EduNote { get; set; }
}
