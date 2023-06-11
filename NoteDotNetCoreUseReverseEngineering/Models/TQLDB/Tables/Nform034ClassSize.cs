using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform034ClassSize
{
    public string Fpk { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string CollegeName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string? TotalName { get; set; }

    public string? DepartmentNum { get; set; }

    public string? ClassName { get; set; }

    public string? GroupName { get; set; }

    public int Jqs { get; set; }

    public string Degree { get; set; } = null!;

    public string DivideClassInfo { get; set; } = null!;
}
