using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TeacherDepartmentList
{
    public int Id { get; set; }

    public int? Year { get; set; }

    public int? TechAdmiSchoolCode { get; set; }

    public string? MoeaschoolCode { get; set; }

    public string? SchoolName { get; set; }

    public string? BelongDepartmentTypeCode { get; set; }

    public int? BelongDepartmentCode { get; set; }

    public string? BelongDepartmentName { get; set; }

    public string? DepartmentTypeCode { get; set; }

    public string? DepartmentTypeName { get; set; }

    public string? SpecialClassTypeName { get; set; }

    public string? MoeadepartmentCode { get; set; }

    public int? TechAdmiDepartmentCode { get; set; }

    public string? DepartmentName { get; set; }

    public string? SchoolSystemCode { get; set; }

    public string? SchoolSystemName { get; set; }

    public decimal? NormalStudyYearLimit { get; set; }

    public decimal? MaxStudyYearLimit { get; set; }
}
