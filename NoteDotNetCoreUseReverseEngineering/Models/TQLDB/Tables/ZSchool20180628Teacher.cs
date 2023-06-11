using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ZSchool20180628Teacher
{
    public int Year { get; set; }

    public string Semester { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string? DbNum { get; set; }

    public string? Tos { get; set; }

    public string? NewTime { get; set; }

    public int? RecentTime { get; set; }

    public string SchoolName { get; set; } = null!;

    public int? AllTeacherStudentRatioStandard { get; set; }

    public string? AllTeacherStudentRatioActual { get; set; }

    public double? 全校學生數 { get; set; }

    public decimal? 全校教師數 { get; set; }

    public string? DayDivisionTeacherStudentRatioActual { get; set; }

    public double? 日間學生數 { get; set; }

    public decimal? 日間教師數 { get; set; }

    public string? MasterTeacherStudentRatioActual { get; set; }

    public double? 研究學生數 { get; set; }

    public int? 研究教師數 { get; set; }
}
