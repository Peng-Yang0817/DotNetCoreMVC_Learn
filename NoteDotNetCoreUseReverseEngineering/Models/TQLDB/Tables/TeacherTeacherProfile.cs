using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TeacherTeacherProfile
{
    public int Id { get; set; }

    public int? Year { get; set; }

    public string? Semister { get; set; }

    public int? TvedbschoolCode { get; set; }

    public string? SchoolName { get; set; }

    public string? DepartmentTypeCode { get; set; }

    public string? DepartmentTypeName { get; set; }

    public int? MainDepartmentCode { get; set; }

    public string? MainDepartmentName { get; set; }

    public string? IdentityType { get; set; }

    public string? HashId { get; set; }

    public int? TeacherId { get; set; }

    public string? ChineseName { get; set; }

    public string? Status { get; set; }

    public DateOnly? HireDate { get; set; }

    public DateOnly? EarliestDueDate { get; set; }

    public string? Division { get; set; }

    public string? AppointmentType { get; set; }

    public string? JobType { get; set; }

    public bool? HasAdministrationJob { get; set; }

    public string? AdminstrationJobName { get; set; }

    public string? EducationSchoolName { get; set; }

    public string? EducationDept { get; set; }

    public string? Education { get; set; }

    public string? Expertise { get; set; }

    public string? TeacherCategory { get; set; }

    public string? AppointmentLevel { get; set; }

    public bool? IsAppointOverYear { get; set; }

    public string? CertificateLevel { get; set; }

    public string? AppointmentNo { get; set; }

    public string? CertificateNo { get; set; }

    public decimal? WorkHoursPerWeek { get; set; }
}
