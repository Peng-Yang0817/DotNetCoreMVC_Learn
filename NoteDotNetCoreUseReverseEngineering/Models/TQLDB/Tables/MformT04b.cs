using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformT04b
{
    public int CurrentYear { get; set; }

    public string? CurrentYearDbNum { get; set; }

    public string CurrentYearschoolName { get; set; } = null!;

    public string CurrentYeardepartmentNum { get; set; } = null!;

    public string CurrentYeardepartmentName { get; set; } = null!;

    public string? CurrentYearNewCategyDepartmentNum { get; set; }

    public string? CurrentYearTheProportionOfFullTimeLecturersStandard { get; set; }

    public string? CurrentYearTheActualProportionOfLecturer { get; set; }

    public int? CurrentYearNumberOfFullTimeTeachersStandard { get; set; }

    public double? CurrentYearTheActualNumber { get; set; }

    public string? CurrentYearPhdMasterStudentTeacherRatio { get; set; }

    public double? CurrentYearStudentTeacherRatio { get; set; }

    public string? CurrentYearAsy { get; set; }

    public string CurrentYearConformOrNot { get; set; } = null!;

    public string? CurrentYearNotConformItem { get; set; }

    public string? CurrentYearEditNote { get; set; }

    public int? LastYear { get; set; }

    public string? LastYeardepartmentNum { get; set; }

    public string? LastYeardepartmentName { get; set; }

    public string? LastYearNewCategyDepartmentNum { get; set; }

    public string? LastYearTheProportionOfFullTimeLecturersStandard { get; set; }

    public string? LastYearTheActualProportionOfLecturer { get; set; }

    public int? LastYearNumberOfFullTimeTeachersStandard { get; set; }

    public double? LastYearTheActualNumber { get; set; }

    public string? LastYearPhdMasterStudentTeacherRatio { get; set; }

    public double? LastYearStudentTeacherRatio { get; set; }

    public string? LastYearAsy { get; set; }

    public string? LastYearConformOrNot { get; set; }

    public string? LastYearNotConformItem { get; set; }

    public string? LastYearEditNote { get; set; }

    public string? TwoYearNotConformItem { get; set; }
}
