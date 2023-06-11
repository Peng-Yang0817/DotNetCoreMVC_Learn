using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneNformC06
{
    public int Id { get; set; }

    public string FormName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int SchoolCtrl001id { get; set; }

    public string ApplicationDepartment { get; set; } = null!;

    public string ApplicationCategory { get; set; } = null!;

    public string DepartmentNum { get; set; } = null!;

    public string? MainField { get; set; }

    public string? SubField { get; set; }

    public string AreaName { get; set; } = null!;

    public string ApplicationSystemName { get; set; } = null!;

    public string ApplicationSystemQuota { get; set; } = null!;

    public string ApprovedEnrollmentQuota { get; set; } = null!;

    public string TotalStudentNum { get; set; } = null!;

    public string? DailySectionNum { get; set; }

    public string? ContinuingEducationNum { get; set; }

    public string ApplicationSystemTemplateStudentNum { get; set; } = null!;

    public string FullTimeTeacherNumTotal { get; set; } = null!;

    public string FullTimeTeacherNumProfessor { get; set; } = null!;

    public string FullTimeTeacherNumAssociateProfessor { get; set; } = null!;

    public string FullTimeTeacherNumAssistantProfessor { get; set; } = null!;

    public string FullTimeTeacherNumLecturer { get; set; } = null!;

    public decimal TeacherPupilPer { get; set; }

    public decimal AfterApplicationTeacherPupilPer { get; set; }

    public string LastEvaluationYear { get; set; } = null!;

    public string LastEvaluationName { get; set; } = null!;

    public string LastEvaluationResult { get; set; } = null!;

    public string LastThreeYearLicenseAcceptanceData { get; set; } = null!;

    public bool IsPassed { get; set; }

    public string? ConferenceDate { get; set; }

    public string? ProposalNum { get; set; }

    public string? ConferenceExpectDate { get; set; }

    public string Comment006 { get; set; } = null!;

    public int OneNformState { get; set; }

    public int EditAuth001 { get; set; }

    public DateTime EditTime { get; set; }

    public string? FullTimeTeacherNumNurse { get; set; }

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

    public string? Comment007 { get; set; }
}
