using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneExamineC13
{
    public string? CaseNum { get; set; }

    public string Year { get; set; } = null!;

    public int SchoolCtrl001id { get; set; }

    public string SchoolName { get; set; } = null!;

    public string Tclnum { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string FormName { get; set; } = null!;

    public string CaseName { get; set; } = null!;

    public string MainField { get; set; } = null!;

    public int OneNformState { get; set; }

    public string FormStateName { get; set; } = null!;

    public int OneNformFileId { get; set; }

    public int OneNformTypeId { get; set; }

    public string OneNformType { get; set; } = null!;

    public string OneNformTypeName { get; set; } = null!;

    public int? RecruitAuth001Id { get; set; }

    public int? Examine01Auth001Id { get; set; }

    public int? Examine02Auth001Id { get; set; }

    public int? Examine03Auth001Id { get; set; }

    public int? Examine04Auth001Id { get; set; }

    public int? Examine05Auth001Id { get; set; }

    public int ExamineState001 { get; set; }

    public int Examine002Id { get; set; }

    public int WriterAuth001Id { get; set; }

    public string? ExamineDeadLine { get; set; }

    public string? ExamineFinishDate { get; set; }

    public int ExamineState002 { get; set; }

    public string OneExamineStateName { get; set; } = null!;

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

    public int Examine001Id { get; set; }

    public int ExamineNum { get; set; }

    public string? OneNformAdjustment { get; set; }
}
