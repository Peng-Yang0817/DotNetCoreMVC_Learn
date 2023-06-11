using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneNformJ01
{
    public int Id { get; set; }

    public string FormName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int SchoolCtrl001id { get; set; }

    public string? CaseName { get; set; }

    public string MainField { get; set; } = null!;

    public string ApprovedQuota { get; set; } = null!;

    public string StopReason { get; set; } = null!;

    public string StopCorrespondCondition1 { get; set; } = null!;

    public string StopCorrespondCondition2 { get; set; } = null!;

    public string EvidenceDescription { get; set; } = null!;

    public bool HaveNotification { get; set; }

    public string? NotificationDate { get; set; }

    public string UndergraduateSupportMeasurement { get; set; } = null!;

    public string TeachersCustomizePlan { get; set; } = null!;

    public string StopQuotaPlanning { get; set; } = null!;

    public string EducationSystemAndApprovedQuotaData { get; set; } = null!;

    public string LastThreeYearsRegisterRateData { get; set; } = null!;

    public string LastThreeYearsApplyData { get; set; } = null!;

    public string LastThreeYearsDepartmentStopApprovedSituation { get; set; } = null!;

    public bool IsPassed { get; set; }

    public string? ConferenceDate { get; set; }

    public string? ProposalNum { get; set; }

    public string? ConferenceExpectDate { get; set; }

    public string RelatedProcessDescription { get; set; } = null!;

    public string TotalGraduateNum { get; set; } = null!;

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
