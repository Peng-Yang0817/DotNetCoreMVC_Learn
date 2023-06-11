using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformT03b
{
    public int Year { get; set; }

    public string? DbNum { get; set; }

    public string SchoolName { get; set; } = null!;

    public string DepartmentNum { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public string NewCategyDepartmentNum { get; set; } = null!;

    public string TheProportionOfFullTimeLecturersStandard { get; set; } = null!;

    public string TheActualProportionOfLecturer { get; set; } = null!;

    public int NumberOfFullTimeTeachersStandard { get; set; }

    public double? TheActualNumber { get; set; }

    public string PhdMasterStudentTeacherRatio { get; set; } = null!;

    public double StudentTeacherRatio { get; set; }

    public string? Asy { get; set; }

    public string ConformOrNot { get; set; } = null!;

    public string? NotConformItem { get; set; }

    public string? EditNote { get; set; }
}
