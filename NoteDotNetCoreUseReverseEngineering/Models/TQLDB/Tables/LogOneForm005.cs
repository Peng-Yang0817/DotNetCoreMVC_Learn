using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogOneForm005
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public int SchoolCtrl001Id { get; set; }

    public string Year { get; set; } = null!;

    public string ProjectName { get; set; } = null!;

    public int State011Id { get; set; }

    public string C1 { get; set; } = null!;

    public string C2 { get; set; } = null!;

    public string? C3 { get; set; }

    public string? C4 { get; set; }

    public string C5 { get; set; } = null!;

    public string C6 { get; set; } = null!;

    public int? State018Id { get; set; }

    public string? C7 { get; set; }

    public string C8 { get; set; } = null!;

    public string? OneFormUploadId { get; set; }

    public DateTime EditTime { get; set; }

    public int EditAuth001 { get; set; }

    public DateTime LogTime { get; set; }
}
