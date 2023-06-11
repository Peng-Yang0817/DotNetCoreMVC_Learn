using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformT02a20180706
{
    public int Id { get; set; }

    public int Year { get; set; }

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public string CategoryDepartmentNum { get; set; } = null!;

    public string CategoryDepartment { get; set; } = null!;

    public string DepartmentNum { get; set; } = null!;

    public string CollegeName { get; set; } = null!;

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

    public double? SupportProf { get; set; }

    public double? SupportAssocProf { get; set; }

    public double? SupportTa { get; set; }

    public double? SupportLecturer { get; set; }

    public double? SupportRn { get; set; }

    public double? SupportAdvisor { get; set; }

    public double? EmployTeacherNum { get; set; }

    public double? SupportStudentTotal { get; set; }

    public double? SupportDeferTotal { get; set; }

    public double? SupportTeacherTotal { get; set; }

    public string? SupportOpen { get; set; }

    public string? Asy { get; set; }

    public string? EditNote { get; set; }

    public DateTime EditTime { get; set; }
}
