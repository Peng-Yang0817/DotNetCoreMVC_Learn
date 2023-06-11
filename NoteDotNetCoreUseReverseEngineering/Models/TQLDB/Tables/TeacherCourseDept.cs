using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TeacherCourseDept
{
    public int Id { get; set; }

    public int? Year { get; set; }

    public string? Semester { get; set; }

    public int? TvedbschoolCode { get; set; }

    public string? CourseCode { get; set; }

    public string? DepartmentTypeCode { get; set; }

    public string? DepartmentTypeName { get; set; }

    public int? DepartmentCode { get; set; }

    public string? DepartmentName { get; set; }

    public string? SchoolSystemCode { get; set; }

    public string? SchoolSystemName { get; set; }
}
