using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneForm009
{
    public int Id { get; set; }

    public int SchoolCtrl001Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public string Tclnum { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string? DepartmentName { get; set; }

    public int? C1 { get; set; }

    public string? C2 { get; set; }

    public string? C3 { get; set; }

    public string? OneFormUploadId { get; set; }

    public string? FileName { get; set; }

    public DateTime? OneFormUploadTime { get; set; }

    public DateTime EditTime { get; set; }

    public int EditAuth001 { get; set; }

    public string Username { get; set; } = null!;

    public string Name { get; set; } = null!;
}
