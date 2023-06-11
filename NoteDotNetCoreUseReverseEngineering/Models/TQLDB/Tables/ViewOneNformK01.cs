using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneNformK01
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

    public string SchoolName { get; set; } = null!;

    public string Tclnum { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string? SchoolArea { get; set; }

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string FormStateName { get; set; } = null!;

    public int OneNformTypeId { get; set; }

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

    public string Username { get; set; } = null!;

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
