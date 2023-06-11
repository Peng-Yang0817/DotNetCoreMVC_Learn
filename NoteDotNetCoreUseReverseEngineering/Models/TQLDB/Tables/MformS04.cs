using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformS04
{
    public int Year { get; set; }

    public string Semester { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string? DbNum { get; set; }

    public string? Tos { get; set; }

    public string? NewTime西曆 { get; set; }

    public DateOnly? NewTime國曆 { get; set; }

    public int? RecentTime { get; set; }

    public string SchoolName { get; set; } = null!;

    public int? AllTeacherStudentRatioStandard { get; set; }

    public string? AllTeacherStudentRatioActual { get; set; }

    public string? DayDivisionTeacherStudentRatioActual { get; set; }

    public string? MasterTeacherStudentRatioActual { get; set; }

    public string? Tastandard { get; set; }

    public string? Taactual { get; set; }

    public double AreaStandard { get; set; }

    public double? AreaActual { get; set; }

    public double? Allowance { get; set; }
}
