using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformT01a20180706
{
    public int Id { get; set; }

    public int Year { get; set; }

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public string CategyDepartmentNum { get; set; } = null!;

    public string CategyDepartment { get; set; } = null!;

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

    public double? DeferGraeutionPhD { get; set; }

    public double? DeferGraeutionMaster { get; set; }

    public double? DeferGraeutionOtjmaster { get; set; }

    public double? DeferGraeutionDegree { get; set; }

    public double? DeferGraeutionNightDegree { get; set; }

    public double? DeferGraeutionCollege { get; set; }

    public double? DeferGraeutionJuniorCollege { get; set; }

    public double? DeferGraeutionNightJuniorCollege { get; set; }

    public double? DegreeProf { get; set; }

    public double? DegreeAssocProf { get; set; }

    public double? DegreeTa { get; set; }

    public double? DegreeLecturer { get; set; }

    public double? DegreeRn { get; set; }

    public double? DegreeAdvisor { get; set; }

    public double? DegreePtporf { get; set; }

    public double? DegreePtassocProf { get; set; }

    public double? DegreePtta { get; set; }

    public double? DegreePtlecturer { get; set; }

    public double? Total { get; set; }

    public string? Asy { get; set; }

    public string? EditNote { get; set; }

    public DateTime EditTime { get; set; }
}
