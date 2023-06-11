using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneNformK01
{
    public int Id { get; set; }

    public string FormName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int SchoolCtrl001id { get; set; }

    public string CaseName { get; set; } = null!;

    public string IncrementNum { get; set; } = null!;

    public string IncrementData { get; set; } = null!;

    public string Condition { get; set; } = null!;

    public string ApplicationConform { get; set; } = null!;

    public string IncrementReason { get; set; } = null!;

    public string IncrementQuotaPlan { get; set; } = null!;

    public string? ContactName { get; set; }

    public string? ContactDepartment { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactMail { get; set; }

    public string? LastThreeYearApprovedQuota1 { get; set; }

    public string? LastThreeYearApprovedQuota2 { get; set; }

    public string? LastThreeYearApprovedQuota3 { get; set; }

    public string? LastThreeYearApplicateQuota1 { get; set; }

    public string? LastThreeYearApplicateQuota2 { get; set; }

    public string? LastThreeYearApplicateQuota3 { get; set; }

    public string? LastThreeYearDecreasementQuota1 { get; set; }

    public string? LastThreeYearDecreasementQuota2 { get; set; }

    public string? LastThreeYearDecreasementQuota3 { get; set; }

    public string? LastThreeYearDecreasementReason1 { get; set; }

    public string? LastThreeYearDecreasementReason2 { get; set; }

    public string? LastThreeYearDecreasementReason3 { get; set; }

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
