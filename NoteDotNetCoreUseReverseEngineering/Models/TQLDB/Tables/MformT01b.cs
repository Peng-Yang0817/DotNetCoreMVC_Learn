using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformT01b
{
    public int Year { get; set; }

    public string? DbNum { get; set; }

    public string? SchoolNum { get; set; }

    public string SchoolName { get; set; } = null!;

    public string DepartmentNum { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public double? InSchoolPhD { get; set; }

    public double? InSchoolMaster { get; set; }

    public double? InSchoolOtjmaster { get; set; }

    public double? InSchoolDegree { get; set; }

    public double? InSchoolNightDegree { get; set; }

    public double? InSchoolCollege { get; set; }

    public double? InSchoolJuniorCollege { get; set; }

    public double? InSchoolNightJuniorCollege { get; set; }

    public double InSchoolTotal { get; set; }

    public double? DeferGraeutionPhD { get; set; }

    public double? DeferGraeutionMaster { get; set; }

    public double? DeferGraeutionOtjmaster { get; set; }

    public double? DeferGraeutionDegree { get; set; }

    public double? DeferGraeutionNightDegree { get; set; }

    public double? DeferGraeutionCollege { get; set; }

    public double? DeferGraeutionJuniorCollege { get; set; }

    public double? DeferGraeutionNightJuniorCollege { get; set; }

    public double DeferGraeutionTotal { get; set; }

    public double? DegreeProf { get; set; }

    public double? DegreeAssocProf { get; set; }

    public double? DegreeTa { get; set; }

    public double? DegreeLecturer { get; set; }

    public double? DegreeRn { get; set; }

    public double? DegreeAdvisor { get; set; }

    public double DegreeTotal { get; set; }

    public double? DegreePtporf { get; set; }

    public double? DegreePtassocProf { get; set; }

    public double? DegreePtta { get; set; }

    public double? DegreePtlecturer { get; set; }

    public double DegreePttotal { get; set; }

    public double? Total { get; set; }

    public string? NewCategyDepartmentNum { get; set; }

    public string? TheProportionOfFullTimeLecturersStandard { get; set; }

    public string? TheActualProportionOfLecturer { get; set; }

    public int? NumberOfFullTimeTeachersStandard { get; set; }

    public double? TheActualNumber { get; set; }

    public double? PhdMasterStudentTeacherRatio { get; set; }

    public double? StudentTeacherRatio { get; set; }

    public string? Asy { get; set; }

    public string ConformOrNot { get; set; } = null!;

    public string? NotConformItem { get; set; }

    public string? EditNote { get; set; }
}
