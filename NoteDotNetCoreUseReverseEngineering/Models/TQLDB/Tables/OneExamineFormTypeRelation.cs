using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneExamineFormTypeRelation
{
    public int Id { get; set; }

    public string? OneNformAdjustment { get; set; }

    public string? ExamineFormat { get; set; }

    public string? RecruitFormat { get; set; }
}
