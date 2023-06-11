using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneNformB01
{
    public int Id { get; set; }

    public string FormName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int SchoolCtrl001id { get; set; }

    public string CaseName { get; set; } = null!;

    public string DepartmentNum { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public string Enrollment { get; set; } = null!;

    public string College { get; set; } = null!;

    public string DegreeName { get; set; } = null!;

    public string MainField { get; set; } = null!;

    public string? SubField { get; set; }

    public string RelatedDegreeData { get; set; } = null!;

    public bool IsFirstApply { get; set; }

    public string? LastApplyYear { get; set; }

    public bool IsPassed { get; set; }

    public string? ConferenceDate { get; set; }

    public string? ProposalNum { get; set; }

    public string? ConferenceExpectDate { get; set; }

    public string ManagerName { get; set; } = null!;

    public string ManagerJobTitle { get; set; } = null!;

    public string ManagerPhone { get; set; } = null!;

    public string ManagerMail { get; set; } = null!;

    public string? ApplicantName { get; set; }

    public string? ApplicantJobTitle { get; set; }

    public string? ApplicantPhone { get; set; }

    public string? ApplicantMail { get; set; }

    public string Comment001 { get; set; } = null!;

    public string Comment002 { get; set; } = null!;

    public string Comment003 { get; set; } = null!;

    public string Comment004 { get; set; } = null!;

    public string Comment005 { get; set; } = null!;

    public string Comment006 { get; set; } = null!;

    public decimal TeacherPupilPer001 { get; set; }

    public decimal TeacherPupilPer002 { get; set; }

    public decimal TeacherPupilPer003 { get; set; }

    public decimal TeacherPupilPer004 { get; set; }

    public bool EvaluationIsPassed { get; set; }

    public string? EvaluationName { get; set; }

    public string? EvaluationYear { get; set; }

    public string? EvaluationResult { get; set; }

    public string ApplyOption { get; set; } = null!;

    public bool? HaveInServiceMaster { get; set; }

    public string? InServiceMasterEstablishedYear { get; set; }

    public string? MasterDayEstablishedYear { get; set; }

    public string FullTimeTeacher001 { get; set; } = null!;

    public string FullTimeTeacher002 { get; set; } = null!;

    public string FullTimeTeacher003 { get; set; } = null!;

    public string FullTimeTeacher004 { get; set; } = null!;

    public string FullTimeTeacher005 { get; set; } = null!;

    public string FullTimeTeacher006 { get; set; } = null!;

    public string? FullTimeTeacherTotal1 { get; set; }

    public string? FullTimeTeacherTotal2 { get; set; }

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

    public string? Comment007 { get; set; }

    public string? SetUpFullYear { get; set; }
}
