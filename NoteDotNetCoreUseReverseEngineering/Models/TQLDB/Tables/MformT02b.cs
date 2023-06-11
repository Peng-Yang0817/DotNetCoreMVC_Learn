using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformT02b
{
    public int Year { get; set; }

    public string? DbNum { get; set; }

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public string DepartmentNum { get; set; } = null!;

    public string CollegeName { get; set; } = null!;

    public double? InSchoolPhD { get; set; }

    public double? InSchoolMaster { get; set; }

    public double? InSchoolOtjmaster { get; set; }

    public double? InSchoolDegree { get; set; }

    public double? InSchoolNightDegree { get; set; }

    public double InSchoolTotal { get; set; }

    public double? DeferGraeutionPhD { get; set; }

    public double? DeferGraeutionMaster { get; set; }

    public double? DeferGraeutionOtjmaster { get; set; }

    public double? DeferGraeutionDegree { get; set; }

    public double? DeferGraeutionNightDegree { get; set; }

    public double DeferGraeutionTotal { get; set; }

    public double? SupportProf { get; set; }

    public double? SupportAssocProf { get; set; }

    public double? SupportTa { get; set; }

    public double? SupportLecturer { get; set; }

    public double? SupportRn { get; set; }

    public double? SupportAdvisor { get; set; }

    public double SupportTotal { get; set; }

    public double? EmployTeacherNum { get; set; }

    public double? SupportStudentTotal { get; set; }

    public double? SupportDeferTotal { get; set; }

    public double? SupportTeacherTotal { get; set; }

    public string? SupportOpen { get; set; }

    public string? NewCategoryDepartmentNum { get; set; }

    public string? TheProportionOfFullTimeLecturersStandard { get; set; }

    public string? TheActualProportionOfLecturer { get; set; }

    public int NumberOfFullTimeTeachersStandard { get; set; }

    public double? TheActualNumber { get; set; }

    public string PhdMasterStudentTeacherRatio { get; set; } = null!;

    public double? StudentTeacherRatio { get; set; }

    public string? Asy { get; set; }

    public string ConformOrNot { get; set; } = null!;

    public string? NotConformItem { get; set; }

    public string? EditNote { get; set; }
}
