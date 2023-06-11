using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneNformF01
{
    public int Id { get; set; }

    public string FormName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int SchoolCtrl001id { get; set; }

    public string? MainField { get; set; }

    public string? SubField { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string EducationSystemName { get; set; } = null!;

    public string EnrollmentQuota { get; set; } = null!;

    public string EnrollmentDescription { get; set; } = null!;

    public string ApprovedSystemName { get; set; } = null!;

    public string FullTimeTeacherTotalNum { get; set; } = null!;

    public string FullTimeTeacherProfessorNum { get; set; } = null!;

    public string FullTimeTeacherAssociateProfessorNum { get; set; } = null!;

    public string FullTimeTeacherAssistantProfessorNum { get; set; } = null!;

    public string FullTimeTeacherLectureNum { get; set; } = null!;

    public string? GraduateTotalNum { get; set; }

    public string GraduateEmploymentNum { get; set; } = null!;

    public decimal GraduateEmploymentPercent { get; set; }

    public string GraduateProgressionNum { get; set; } = null!;

    public decimal GraduateProgressionPercent { get; set; }

    public string GraduateAbroadNum { get; set; } = null!;

    public decimal GraduateAbroadPercent { get; set; }

    public string GraduateMilitaryNum { get; set; } = null!;

    public decimal GraduateMilitaryPercent { get; set; }

    public string GraduateOthersNum { get; set; } = null!;

    public decimal GraduateOthersPercent { get; set; }

    public string? GraduateRemark { get; set; }

    public bool IsPassed { get; set; }

    public string? ConferenceDate { get; set; }

    public string? ProposalNum { get; set; }

    public string? ConferenceExpectDate { get; set; }

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
