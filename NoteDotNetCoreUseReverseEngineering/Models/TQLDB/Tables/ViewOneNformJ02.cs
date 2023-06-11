using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneNformJ02
{
    public int Id { get; set; }

    public string FormName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int SchoolCtrl001id { get; set; }

    public string CaseName { get; set; } = null!;

    public string CourseName { get; set; } = null!;

    public string ApprovedSystem { get; set; } = null!;

    public string SuspendData { get; set; } = null!;

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

    public string SchoolName { get; set; } = null!;

    public string Tclnum { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string? SchoolArea { get; set; }

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string FormStateName { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string? FileName1 { get; set; }

    public string? FilePath1 { get; set; }

    public string? FileGuid1 { get; set; }

    public string? FileName2 { get; set; }

    public string? FilePath2 { get; set; }

    public string? FileGuid2 { get; set; }

    public string? FileName3 { get; set; }

    public string? FilePath3 { get; set; }

    public string? FileGuid3 { get; set; }

    public string? FileName4 { get; set; }

    public string? FilePath4 { get; set; }

    public string? FileGuid4 { get; set; }

    public string OneNformType { get; set; } = null!;

    public string OneNformTypeName { get; set; } = null!;

    public string? OneNformAdjustment { get; set; }

    public int OneNformTypeId { get; set; }

    public int OneNformFileId { get; set; }

    public string? Remind { get; set; }

    public string? ExportFileName { get; set; }

    public string? MainFieldEdited { get; set; }

    public string? SubFieldEdited { get; set; }

    public bool? ExamineEnabled { get; set; }

    public bool? ApprovedResult { get; set; }

    public string? ExamineResultNum { get; set; }

    public string? Expr1 { get; set; }
}
