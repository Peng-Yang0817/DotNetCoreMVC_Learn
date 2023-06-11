using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewExamineWriterResultExport
{
    public string Fpk { get; set; } = null!;

    public int OneExamine001Id { get; set; }

    public int WriterAuth001Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public string? CaseName { get; set; }

    public string? Adjustment { get; set; }

    public string WriterName { get; set; } = null!;

    public string Content1 { get; set; } = null!;

    public string Content2 { get; set; } = null!;

    public string Content3 { get; set; } = null!;

    public string Content4 { get; set; } = null!;

    public string Content5 { get; set; } = null!;

    public string Content6 { get; set; } = null!;

    public string Content7 { get; set; } = null!;

    public string? ContentTotal { get; set; }

    public string? ContentResult { get; set; }
}
