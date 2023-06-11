using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneNformA01
{
    public int Id { get; set; }

    public string FormName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int SchoolCtrl001id { get; set; }

    public string ApplicationCategory { get; set; } = null!;

    public string? EducationUnit { get; set; }

    public bool LectureInEnglish { get; set; }

    public string CaseNameChinese { get; set; } = null!;

    public string? CaseNameEnglish { get; set; }

    public bool? ForeignProgram { get; set; }

    public decimal? TeacherPupilPer001 { get; set; }

    public decimal? TeacherPupilPer002 { get; set; }

    public decimal? TeacherPupilPer003 { get; set; }

    public string? TeacherStructure { get; set; }

    public string DepartmentNum { get; set; } = null!;

    public string OrderSerial { get; set; } = null!;

    public string MainField { get; set; } = null!;

    public string? SubField { get; set; }

    public string? SubField2 { get; set; }

    public string CentralOffice { get; set; } = null!;

    public bool IsFirstApply { get; set; }

    public string? LastApplyYear { get; set; }

    public string? LastApplyCaseName { get; set; }

    public bool IsPassed { get; set; }

    public string? ConferenceDate { get; set; }

    public string? ProposalNum { get; set; }

    public string? ConferenceExpectDate { get; set; }

    public string DegreeName { get; set; } = null!;

    public string? RelatedDegreeProgramData { get; set; }

    public string? RelatedSchoolData { get; set; }

    public string EnrollmentPipeline { get; set; } = null!;

    public string EnrollmentDescription { get; set; } = null!;

    public string GraduateEmploymentDescription { get; set; } = null!;

    public string ApplicantJobTitle { get; set; } = null!;

    public string ApplicantName { get; set; } = null!;

    public string ApplicantPhone { get; set; } = null!;

    public string ApplicantFax { get; set; } = null!;

    public string ApplicantMail { get; set; } = null!;

    public string CommitteeList { get; set; } = null!;

    public string? SuggestProfessoerName { get; set; }

    public string? SuggestReason { get; set; }

    public int OneNformState { get; set; }

    public int EditAuth001 { get; set; }

    public DateTime EditTime { get; set; }

    /// <summary>
    /// 提醒文字
    /// </summary>
    public string? Remind { get; set; }

    /// <summary>
    /// 匯出檔案名稱
    /// </summary>
    public string? ExportFileName { get; set; }

    /// <summary>
    /// 修正後主領域
    /// </summary>
    public string? MainFieldEdited { get; set; }

    /// <summary>
    /// 修正後副領域
    /// </summary>
    public string? SubFieldEdited { get; set; }

    /// <summary>
    /// 送審否
    /// </summary>
    public bool? ExamineEnabled { get; set; }

    /// <summary>
    /// 核定最終結果
    /// </summary>
    public bool? ApprovedResult { get; set; }

    /// <summary>
    /// 審查結果字號
    /// </summary>
    public string? ExamineResultNum { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Notes { get; set; }
}
