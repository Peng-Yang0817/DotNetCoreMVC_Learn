using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogSchoolCtrl004
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string ShuoBoShrBanName { get; set; } = null!;

    public int? SchoolCtrl002Id { get; set; }

    public string? ClassName { get; set; }

    public string? GroupName { get; set; }

    public string? CategoryName { get; set; }

    public int SchoolCtrl003Id { get; set; }

    public string? DepartmentNum { get; set; }

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string? ApprovedUnit { get; set; }

    public int? State005Id { get; set; }

    public int? State009Id { get; set; }

    public int? State010Id { get; set; }

    public DateTime EditTime { get; set; }

    public int Auth001Id { get; set; }

    public string? ClassGroupCode { get; set; }

    public string? TotalDepartmentCode { get; set; }

    public DateTime LogTime { get; set; }
}
