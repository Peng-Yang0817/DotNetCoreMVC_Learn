using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TeacherCourseProfile
{
    public int Id { get; set; }

    public int? Year { get; set; }

    public string? Semester { get; set; }

    public int? TvedbschoolCode { get; set; }

    public string? SchoolName { get; set; }

    public string? CourseCode { get; set; }

    public string? CourseName { get; set; }

    public string? CourseTypeName { get; set; }

    public string? CourseType { get; set; }

    public decimal? CourseHours { get; set; }

    public decimal? PraticalHours { get; set; }

    public decimal? Credits { get; set; }

    public DateOnly? FirstCourseDate { get; set; }

    public int? MaleStudentAmount { get; set; }

    public int? FemaleStudentAmount { get; set; }

    public string? Language { get; set; }

    public bool? IsGraduateCourse { get; set; }

    public string? BreakType { get; set; }

    public bool? IsForeignLanguageAllTime { get; set; }

    public bool? IsProfessionalEnglishCourse { get; set; }

    public string? CourseCategory { get; set; }
}
