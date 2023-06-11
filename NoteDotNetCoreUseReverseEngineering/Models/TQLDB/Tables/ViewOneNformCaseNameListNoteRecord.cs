using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneNformCaseNameListNoteRecord
{
    public int OneNformTypeId { get; set; }

    public string Year { get; set; } = null!;

    public int OneNformId { get; set; }

    public string Tclnum { get; set; } = null!;

    public int SchoolCtrl001Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public string OneNformType { get; set; } = null!;

    public string? CaseName { get; set; }

    public string? OneNformAdjustment { get; set; }

    public string? Remind { get; set; }

    public string? ExportFileName { get; set; }

    public string? MainField { get; set; }

    public string? SubField { get; set; }

    public string? MainFieldEdited { get; set; }

    public string? SubFieldEdited { get; set; }

    public bool? ExamineEnabled { get; set; }

    public bool? ApprovedResult { get; set; }

    public string? ExamineResultNum { get; set; }

    public string? Notes { get; set; }

    public string RemindText { get; set; } = null!;

    public string ApprovedResults { get; set; } = null!;

    public string ExResultNum { get; set; } = null!;

    public string Remork { get; set; } = null!;
}
