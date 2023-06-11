using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneNformFile
{
    public string Year { get; set; } = null!;

    public int OneNformId { get; set; }

    public string Tclnum { get; set; } = null!;

    public int SchoolCtrl001Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public string? CaseName { get; set; }

    public string OneNformType { get; set; } = null!;

    public string? FileName1 { get; set; }

    public string? FilePath1 { get; set; }

    public string? FileName2 { get; set; }

    public string? FilePath2 { get; set; }

    public string? FileName3 { get; set; }

    public string? FilePath3 { get; set; }

    public string? FileName4 { get; set; }

    public string? FilePath4 { get; set; }
}
