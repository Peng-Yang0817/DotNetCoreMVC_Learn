using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ZSchool20180628DepTeacher
{
    public int Year { get; set; }

    public string? DbNum { get; set; }

    public string? SchoolNum { get; set; }

    public string SchoolName { get; set; } = null!;

    public string DepartmentNum { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public double Tnum { get; set; }
}
