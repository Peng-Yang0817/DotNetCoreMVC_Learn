using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TeacherCourseTeacher
{
    public int Id { get; set; }

    public int? Year { get; set; }

    public string? Semester { get; set; }

    public int? TvedbschoolCode { get; set; }

    public string? CourseCode { get; set; }

    public int? TeacherId { get; set; }

    public string? HashId { get; set; }

    public string? TeacherName { get; set; }

    public decimal? WorkHours { get; set; }
}
