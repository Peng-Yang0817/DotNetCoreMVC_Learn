using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneNformJ02
{
    public int Id { get; set; }

    public string FormName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int SchoolCtrl001id { get; set; }

    public string CaseName { get; set; } = null!;

    public string CourseName { get; set; } = null!;

    public string ApprovedSystem { get; set; } = null!;

    public string SuspendData { get; set; } = null!;

    public int? SuspendCreateYear { get; set; }

    public bool? HaveSuspendCustomizeYear { get; set; }

    public string? SuspendCustomizeYear { get; set; }

    public bool IsPassed { get; set; }

    public string? ConferenceDate { get; set; }

    public string? ProposalNum { get; set; }

    public string? ConferenceExpectDate { get; set; }

    public string ProcessDescription { get; set; } = null!;

    public bool HaveNotification { get; set; }

    public string? NotificationDetails { get; set; }

    public string? MeasureDescription { get; set; }

    public string? Remarks { get; set; }

    public string AdjustmentName { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public string PlanAfterApplication { get; set; } = null!;

    public string ApplicationReason { get; set; } = null!;

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
