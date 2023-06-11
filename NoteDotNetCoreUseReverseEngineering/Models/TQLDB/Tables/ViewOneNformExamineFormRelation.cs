using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneNformExamineFormRelation
{
    public int Id { get; set; }

    public string OneNformType { get; set; } = null!;

    public string OneNformTypeName { get; set; } = null!;

    public string? OneNformAdjustment { get; set; }

    public string? ExamineFormat { get; set; }

    public string? RecruitFormat { get; set; }
}
