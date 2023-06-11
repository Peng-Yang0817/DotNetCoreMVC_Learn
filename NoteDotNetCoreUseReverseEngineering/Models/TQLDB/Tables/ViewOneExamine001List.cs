using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneExamine001List
{
    public int Id { get; set; }

    public int? ExamineYear { get; set; }

    public int? OneNformTypeId { get; set; }

    public string? OneNformAdjustment { get; set; }

    public int OneNformId { get; set; }

    public string? SerialName { get; set; }

    public string? CaseName { get; set; }

    public string Tclnum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public int? RecruitAuth001Id { get; set; }

    public string? RcName { get; set; }

    public string? RecruitExamineState { get; set; }

    public int? Examine01Auth001Id { get; set; }

    public string? E01Name { get; set; }

    public string? Examine01ExamineState { get; set; }

    public int? Examine02Auth001Id { get; set; }

    public string? E02Name { get; set; }

    public string? Examine02ExamineState { get; set; }

    public int? Examine03Auth001Id { get; set; }

    public string? E03Name { get; set; }

    public string? Examine03ExamineState { get; set; }

    public int? Examine04Auth001Id { get; set; }

    public string? E04Name { get; set; }

    public string? Examine04ExamineState { get; set; }

    public int? Examine05Auth001Id { get; set; }

    public string? E05Name { get; set; }

    public int? Examine05ExamineState { get; set; }

    public int ExamineState001 { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}
