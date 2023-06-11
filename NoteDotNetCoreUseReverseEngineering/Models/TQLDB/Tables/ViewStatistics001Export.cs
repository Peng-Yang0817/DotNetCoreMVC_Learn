using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewStatistics001Export
{
    public string Fpk { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string? SchoolName { get; set; }

    public int? SchoolCtrl001Id { get; set; }

    public string? Tclnum { get; set; }

    public string? SchoolNum { get; set; }

    public string? DepartmentNum { get; set; }

    public string Degree { get; set; } = null!;

    public int? Jqs { get; set; }

    public string? CollegeName { get; set; }

    public string? TotalName { get; set; }

    public string? DepartmentName { get; set; }

    public string? ClassName { get; set; }

    public string? GroupName { get; set; }

    public string? DepartmentAreaName { get; set; }

    public int? SchoolCtrl004Id { get; set; }

    public string? ClassGroupCode { get; set; }
}
